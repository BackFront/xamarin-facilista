using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XF.Facilista.Config;
using XF.Facilista.Entities;

namespace XF.Facilista.Repositories
{
    public class ProductSQLiteRepository : IDisposable
    {
        private SQLite.SQLiteConnection connection;
        string pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public ProductSQLiteRepository()
        {
            //var dbConfig = DependencyService.Get<IDbPathConfig>();
            //var caminho = Path.Combine(dbConfig.Path, "items.db");

            
            using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "mock_data.sqlite")))
            {
                conexao.CreateTable<Product>();
                connection = conexao;
            }
            
            //string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "database.db3");

            //connection = new SQLite.SQLiteConnection(dbPath);
            //connection.CreateTable<Product>();
        }

        public List<Product> GetList() => connection.Table<Product>().ToList();

        public Product Get(int id) => connection.Table<Product>().Where(i => i.ID == id).FirstOrDefault();

        public void Insert(Product _product) => connection.Insert(_product);

        public void Update(Product _product) => connection.Update(_product);

        public void Delete(Product _product) => connection.Delete(_product);

        public void DropTable() => connection.DropTable<Product>();

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Dispose(); // Liberar a conexão
            }
        }
    }
}
