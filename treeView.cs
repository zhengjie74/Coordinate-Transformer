using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LocationTransform
{
    public partial class treeView : Form
    {
        public treeView()
        {
            InitializeComponent();
            LoadDatabaseSchema();
        }

        private void LoadDatabaseSchema()
        {
            string connectionString = "Data Source=pointDatas.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var tables = GetTables(connection);
                foreach (var table in tables)
                {
                    var tableNode = new TreeNode(table);
                    var rows = GetRows(connection, table);
                    foreach (var row in rows)
                    {
                        if (row.ContainsKey("PointName"))
                        {
                            var rowNode = new TreeNode(row["PointName"].ToString());
                            foreach (var key in row.Keys)
                            {
                                if (key != "PointName")
                                {
                                    var columnNode = new TreeNode($"{key}: {row[key]}");
                                    rowNode.Nodes.Add(columnNode);
                                }
                            }
                            tableNode.Nodes.Add(rowNode);
                        }
                        else
                        {
                            var rowNode = new TreeNode("Unnamed Row");
                            foreach (var key in row.Keys)
                            {
                                var columnNode = new TreeNode($"{key}: {row[key]}");
                                rowNode.Nodes.Add(columnNode);
                            }
                            tableNode.Nodes.Add(rowNode);
                        }
                    }
                    treeView1.Nodes.Add(tableNode);
                }
            }
        }

        private List<string> GetTables(SQLiteConnection connection)
        {
            var tables = new List<string>();
            string query = "SELECT name FROM sqlite_master WHERE type='table';";
            using (var command = new SQLiteCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    tables.Add(reader.GetString(0));
                }
            }
            return tables;
        }

        private List<Dictionary<string, object>> GetRows(SQLiteConnection connection, string tableName)
        {
            var rows = new List<Dictionary<string, object>>();
            string query = $"SELECT * FROM {tableName};";
            using (var command = new SQLiteCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader.GetValue(i);
                    }
                    rows.Add(row);
                }
            }
            return rows;
        }
    }
}
