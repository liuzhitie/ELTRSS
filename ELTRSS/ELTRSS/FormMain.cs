using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Data.SQLite;

namespace ELTRSS
{
    public partial class FormMain : Form
    {

        #region 成员变量

        //数据库连接
        SQLiteConnection m_dbConnection;

        // 文件名称
        String m_strDBFileName;
        String m_strDBCnnName;

        #endregion 成员变量


        public FormMain()
        {
            this.m_strDBFileName = @"d:\sqlitedata\elite.sqlite.user.data.db";
            this.m_strDBCnnName = @"Data Source=d:\sqlitedata\elite.sqlite.user.data.db;Version=3;";

            InitializeComponent();
        }

        private void m_button_test_sqlite_Click(object sender, EventArgs e)
        {
            createNewDatabase();
            connectToDatabase();
            createTable();
            fillTable();
            printHighscores();
        }

        #region 数据库访问函数


        //创建一个空的数据库
        void createNewDatabase()
        {
            // 删除原有的数据库文件
            if (File.Exists(this.m_strDBFileName))
                File.Delete(this.m_strDBFileName);

            SQLiteConnection.CreateFile(this.m_strDBFileName);
        }

        //创建一个连接到指定数据库
        void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection(m_strDBCnnName);
            m_dbConnection.Open();
        }

        //在指定数据库中创建一个table
        void createTable()
        {
            string sql = "create table user(name varchar(20), code int)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        //插入一些数据
        void fillTable()
        {
            string sql = "insert into user (name, code) values ('刘旋', 1)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into user (name, code) values ('魏红雨', 2)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into user (name, code) values ('刘向华', 3)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into user (name, code) values ('刘东', 4)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

        }

        //使用sql查询语句，并显示结果
        void printHighscores()
        {
            string sql = "select * from user order by name desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                MessageBox.Show("Name: " + reader["name"] + "\tCode: " + reader["code"]);

        }

        #endregion 数据库访问函数
    }
}
