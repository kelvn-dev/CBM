using CBM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CBM.Utilities {
  public class HelperUtils {

    public static string GetTableName(Type type) {
      var tableAttribute = type.GetCustomAttribute<TableAttribute>();
      if (tableAttribute != null) {
        return tableAttribute.Name;
      }
      throw new KeyNotFoundException();
    }

    static bool IsUsedProperty(string propertyName) {
      if (propertyName.Equals("Item") || propertyName.Equals("id") || propertyName.Equals("createdTime")) {
        return false;
      }
      return true;
    }

    static bool IsColumnProperty(PropertyInfo propertyInfo) {
      ColumnAttribute columnAttribute = propertyInfo.GetCustomAttribute<ColumnAttribute>();
      return columnAttribute == null ? false : true;
    }

    public static PropertyInfo[] GetPublicPropertyInfos(Type type) {
      PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
      //return propertyInfos.Where(e => IsUsedProperty(e.Name)).ToArray();
      return propertyInfos.ToArray();
    }

    public static void MapModelToInsertCommand(BaseModel model, SqlCommand command) {
      string sqlQuery = command.CommandText;
      // INSERT INTO admin (id, name, age) VALUES (@name, @age)
      //                    columns             values
      string columns = "(id, created_time, ";
      string values = "(@id, @created_time, ";

      PropertyInfo[]  propertyInfos = GetPublicPropertyInfos(model.GetType());
      foreach (PropertyInfo propertyInfo in propertyInfos) {
        ColumnAttribute column = propertyInfo.GetCustomAttribute<ColumnAttribute>();
        if (column != null) {
          string name = column.Name;
          object value = model[propertyInfo.Name];
          columns += $"{name}, ";
          values += $"@{name}, ";
          command.Parameters.AddWithValue($"@{name}", value == null ? DBNull.Value : value);
        }
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
        ColumnAttribute column = propertyInfo.GetCustomAttribute<ColumnAttribute>();
        if (column != null) {
          string name = column.Name;
          object value = model[propertyInfo.Name];
          if (value != null) {
            Console.WriteLine(value);
            sqlQuery += $"{name} = @{name}, ";
            command.Parameters.AddWithValue($"@{name}", value);
            isEmptyModel = false;
          }
        }
      }
      // Generate an empty query if there is an empty model
      command.CommandText = isEmptyModel ? "" : $@"{sqlQuery.Remove(sqlQuery.Length - 2)} ";
    }
  }
}
