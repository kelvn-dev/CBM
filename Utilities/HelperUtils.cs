using CBM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CBM.Utilities {
  public class HelperUtils {

    public static string GetTableName(Type type) {
      var tableAttribute = type.GetCustomAttribute<TableAttribute>();
      if (tableAttribute != null) {
        return tableAttribute.Name;
      }
      throw new KeyNotFoundException();
    }

    public static PropertyInfo[] GetPublicPropertyInfos(Type type) {
      PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
      return propertyInfos;
    }

    public static void MapModelToInsertCommand(BaseModel model, SqlCommand command) {
      string sqlQuery = command.CommandText;
      // INSERT INTO admin (id, name, age) VALUES (@name, @age)
      //                    columns             values
      string columns = "(id, createdTime";
      string values = "(@id, @createdTime";

      PropertyInfo[]  propertyInfos = GetPublicPropertyInfos(model.GetType());
      foreach (PropertyInfo propertyInfo in propertyInfos) {
        string name = propertyInfo.Name;
        if (name.Equals("Item") || name.Equals("id")) {
          continue;
        }
        object value = model[name];
        columns += $"{name}, ";
        values += $"@{name}, ";
        command.Parameters.AddWithValue($"@{name}", value == null ? DBNull.Value : value);
      }
      // At this stage, the tail of columns and values is having 2 unused characters left
      columns = $"{columns.Remove(columns.Length - 2)})";
      values = $"{values.Remove(values.Length - 2)})";
      command.CommandText = $@"{sqlQuery} {columns} VALUES {values}";
    }

    public static void MapModelToUpdateCommand(BaseModel model, SqlCommand command) {
      string sqlQuery = command.CommandText;
      bool isEmptyModel = true;
      PropertyInfo[] propertyInfos = GetPublicPropertyInfos(model.GetType());
      foreach (PropertyInfo propertyInfo in propertyInfos) {
        string name = propertyInfo.Name;
        if (name.Equals("Item") || name.Equals("id")) {
          continue;
        }
        object value = model[name];
        if (value != null) {
          Console.WriteLine(value);
          sqlQuery += $"{name} = @{name}, ";
          command.Parameters.AddWithValue($"@{name}", value);
          isEmptyModel = false;
        }
      }
      // Generate an empty query if there is an empty model
      command.CommandText = isEmptyModel ? "" : $@"{sqlQuery.Remove(sqlQuery.Length - 2)} ";
    }
  }
}
