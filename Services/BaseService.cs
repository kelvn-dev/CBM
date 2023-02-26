using CBM.Models;
using CBM.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBM.Services {
  public class BaseService<T> where T: BaseModel, new() {

    private static readonly string tableName = HelperUtils.GetTableName(typeof(T));
    //private static PagingService pagingService = new PagingService();
    private static readonly int pageSize = 5;

    public static void Create(T model) {
      string sqlQuery = $"INSERT INTO {tableName}";
      using (var connection = ConnectionFactory.Create()) {
        var command = connection.CreateCommand();
        command.CommandText = sqlQuery;
        HelperUtils.MapModelToInsertCommand(model, command);
        command.Parameters.AddWithValue("@id", model.id);
        command.Parameters.AddWithValue("@createdTime", TimeUtils.GetCurrentFormattedTime());
        Console.WriteLine(command.CommandText);
        try {
          int result = command.ExecuteNonQuery();
          if (result < 1) {
            throw new Exception();
          }
        }
        catch (SqlException ex) {
          throw new Exception(ex.Message);
        }
      }
    }

    public static void Update(T model) {
      string sqlQuery = $"UPDATE {tableName} SET ";
      string condition = "WHERE id = @id";

      using (var connection = ConnectionFactory.Create()) {
        var command = connection.CreateCommand();
        command.CommandText = sqlQuery;
        
        HelperUtils.MapModelToUpdateCommand(model, command);
        
        try {
          if (!string.IsNullOrEmpty(command.CommandText)) {
            command.CommandText += condition;
            command.Parameters.AddWithValue("@id", model.id);
            int result = command.ExecuteNonQuery();
            if (result < 1) {
              throw new Exception();
            }
          }
        }
        catch (SqlException ex) {
          throw new Exception(ex.Message);
        }
      }
    }

    public static void DeleteById(Guid id) {
      string sqlQuery = $@"DELETE FROM {tableName} WHERE id = @id";
      using (var connection = ConnectionFactory.Create()) {
        var command = connection.CreateCommand();
        command.CommandText = sqlQuery;
        command.Parameters.AddWithValue("@id", id);
        try {
          int result = command.ExecuteNonQuery();
        }
        catch (SqlException ex) {
          throw new Exception(ex.Message);
        }
      }
    }

    public static T GetById(Guid id, bool isRequired = true) {
      T model = new T();
      bool isFound = false;
      string sqlQuery = $"SELECT * FROM {tableName} WHERE id = @id";

      using (var connection = ConnectionFactory.Create()) {
        var command = connection.CreateCommand();
        command.CommandText = sqlQuery;
        command.Parameters.AddWithValue("@id", id);
        var reader = command.ExecuteReader();
        while (reader.Read()) {
          for (int i = 0; i < reader.FieldCount; i++) {
            model[reader.GetName(i)] = reader.GetValue(i);
          }
          isFound = true;
          break;
        }
      }
      if (isRequired && !isFound) {
        throw new KeyNotFoundException();
      }
      return model;
    }
  }
}
