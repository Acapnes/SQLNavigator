using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Smo;

namespace SQLBACKUP
{
    public partial class Form1 : Form
    {
        SqlFuncs SqlFuncs = new SqlFuncs();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conStatus.Text = "SUCCESS";
                conStatus.ForeColor = Color.Green;
                groupBox1.Enabled = true;

                if (checkAuth.Checked == true)
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString =
                        "Data Source="
                        + "." /*conString.Text*/
                        + ";"
                        + "Integrated Security=True;"
                        + "Initial Catalog= master ;";
                    conn.Open();

                    SqlCommand command = new SqlCommand(
                        "SELECT NAME FROM master.sys.databases",
                        conn
                    );
                    var adapter = new SqlDataAdapter(command);
                    var dataset = new DataSet();
                    adapter.Fill(dataset);

                    for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {
                        listdb.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
                    }
                }
                else if (checkAuth.Checked == false)
                {
                    SqlCommand command = new SqlCommand(
                        "SELECT NAME FROM master.sys.databases",
                        SqlFuncs.SqlConnection()
                    );

                    var adapter = new SqlDataAdapter(command);
                    var dataset = new DataSet();
                    adapter.Fill(dataset);

                    for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                    {
                        listdb.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
                    }
                }
            }
            catch (Exception error)
            {
                conStatus.Text = "FAIL";
                conStatus.ForeColor = Color.Red;
                MessageBox.Show(error.ToString());
            }
        }

        private void InputControl()
        {
            if (
                !String.IsNullOrEmpty(conString.Text)
                && !String.IsNullOrEmpty(conPassword.Text)
                && !String.IsNullOrEmpty(conUsername.Text)
            )
            {
                button1.Enabled = true;
            }
        }

        private void conString_TextChanged(object sender, EventArgs e)
        {
            InputControl();
        }

        private void conUsername_TextChanged(object sender, EventArgs e)
        {
            InputControl();
        }

        private void conPassword_TextChanged(object sender, EventArgs e)
        {
            InputControl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = "";

            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = true;
            save.InitialDirectory = @"C:\";
            save.Title = "SQL Script Files";
            save.DefaultExt = "sql";
            save.Filter = "sql Dosyaları (*.sql)|*.sql|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                folderPath = save.FileName;
                if (System.IO.File.Exists(save.FileName))
                    System.IO.File.Delete(save.FileName);
            }

            StringBuilder sb = new StringBuilder();
            Server srv = new Server(
                new Microsoft.SqlServer.Management.Common.ServerConnection(
                    "GNC-NB122",
                    "sa",
                    "guncel@123"
                )
            );
            Database dbs = srv.Databases[listdb.SelectedItem.ToString()];
            ScriptingOptions options = new ScriptingOptions();
            options.ScriptData = checkBox1.Checked ? true : false;
            options.ScriptDrops = false;
            options.FileName = $"{folderPath}";
            options.EnforceScriptingOptions = true;
            options.ScriptSchema = true;
            options.IncludeHeaders = true;
            options.AppendToFile = true;
            options.Indexes = true;
            options.WithDependencies = true;

            foreach (Table table in dbs.Tables)
            {
                if (!table.IsSystemObject)
                {
                    table.EnumScript(options);
                }
            }
        }

        private void comboTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter Adapter = new SqlDataAdapter(
                "SELECT * FROM " + comboTables.SelectedItem.ToString() + " ",
                "server = "
                    + conString.Text
                    + "; database = "
                    + listdb.SelectedItem.ToString()
                    + " ; UID = sa; password = guncel@123"
            );
            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            dataGridView1.DataSource = Table;
            dataGridView1.Columns[0].ReadOnly = true;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (i == 0)
                    labelClass.Text += "Class {\n";

                labelClass.Text += $"{dataGridView1.Columns[i].HeaderText} (30)";
            }
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString =
                    "Data Source=GNC-NB122;"
                    + "Initial Catalog= Example ;"
                    + "User id=sa;"
                    + "Password=guncel@123;";
                conn.Open();
                SqlCommand command = new SqlCommand(txtCommand.Text, conn);
                command.ExecuteNonQuery();

                SqlDataAdapter Adapter = new SqlDataAdapter(
                    "SELECT * FROM " + comboTables.SelectedItem.ToString() + " ",
                    "server = "
                        + conString.Text
                        + "; database = "
                        + listdb.SelectedItem.ToString()
                        + " ; UID = sa; password = guncel@123"
                );
                DataTable Table = new DataTable();
                Adapter.Fill(Table);
                dataGridView1.DataSource = Table;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void DisableGroup(Boolean toggle)
        {
            groupBox1.Enabled = toggle;
            groupBox3.Enabled = toggle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = true;
            save.InitialDirectory = @"C:\";
            save.Title = "SQL Backup Files";
            save.DefaultExt = "bak";
            save.Filter = "bak Dosyaları (*.bak)|*.bak|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                folderPath = save.FileName;
                if (System.IO.File.Exists(save.FileName))
                    System.IO.File.Delete(save.FileName);
            }

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=GNC-NB122;"
                + "Initial Catalog= master;"
                + "User id=sa;"
                + "Password=guncel@123;";
            conn.Open();

            SqlCommand command = new SqlCommand(
                "BACKUP DATABASE "
                    + listdb.SelectedItem.ToString()
                    + "  TO DISK = '"
                    + folderPath
                    + "' ",
                conn
            );
            command.ExecuteNonQuery();
        }

        private void listdb_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTables.Items.Clear();
            DisableGroup(true);

            var command = new SqlCommand();
            command.Connection = SqlFuncs.SqlConnection();
            command.CommandType = CommandType.Text;
            if (listdb.SelectedIndex != -1)
            {
                command.CommandText =
                    "USE " + listdb.SelectedItem.ToString() + " SELECT * FROM sys.Tables";

                var adapter = new SqlDataAdapter(command);
                var dataset = new DataSet();

                adapter.Fill(dataset);

                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    comboTables.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO " + comboTables.SelectedItem.ToString() + " VALUES ";
            for (int i = 0; i < dataGridView1.CurrentRow.Cells.Count; i++)
            {
                if (i == 0)
                    insertQuery += "(";

                if (i != 0)
                {
                    if (dataGridView1.CurrentRow.Cells[i].ValueType == typeof(int))
                        insertQuery += dataGridView1.CurrentRow.Cells[i].Value.ToString();
                    else if (dataGridView1.CurrentRow.Cells[i].ValueType == typeof(string))
                        insertQuery +=
                            "'" + dataGridView1.CurrentRow.Cells[i].Value.ToString() + "'";
                    else
                        insertQuery += dataGridView1.CurrentRow.Cells[i].Value.ToString();
                }

                if (i != 0 && i != dataGridView1.CurrentRow.Cells.Count - 1)
                {
                    insertQuery += ", ";
                }

                if (i == dataGridView1.CurrentRow.Cells.Count - 1)
                    insertQuery += ")";
            }

            MessageBox.Show(insertQuery);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE " + comboTables.SelectedItem.ToString() + " SET ";
                for (int i = 0; i < dataGridView1.CurrentRow.Cells.Count; i++)
                {
                    if (dataGridView1.CurrentRow.Cells[i].ColumnIndex != 0)
                    {
                        if (dataGridView1.CurrentRow.Cells[i].ValueType == typeof(int))
                            updateQuery +=
                                dataGridView1.CurrentRow.Cells[i].OwningColumn.HeaderText.ToString()
                                + " = "
                                + dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        else if (dataGridView1.CurrentRow.Cells[i].ValueType == typeof(string))
                            updateQuery +=
                                " "
                                + dataGridView1
                                    .CurrentRow.Cells[i]
                                    .OwningColumn.HeaderText.ToString()
                                + " = "
                                + "'"
                                + dataGridView1.CurrentRow.Cells[i].Value.ToString()
                                + "'";
                    }

                    if (i != 0 && i != dataGridView1.CurrentRow.Cells.Count - 1)
                        updateQuery += ", ";
                }

                updateQuery +=
                    " WHERE "
                    + dataGridView1.CurrentRow.Cells[0].OwningColumn.HeaderText.ToString()
                    + " = "
                    + dataGridView1.CurrentRow.Cells[0].Value.ToString()
                    + "";
                txtCommand.Text = updateQuery;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString =
                    "Data Source=GNC-NB122;"
                    + "Initial Catalog= Example ;"
                    + "User id=sa;"
                    + "Password=guncel@123;";
                conn.Open();
                SqlCommand command = new SqlCommand(updateQuery, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery =
                    "DELETE FROM " + comboTables.SelectedItem.ToString() + " WHERE ";

                deleteQuery +=
                    dataGridView1.CurrentRow.Cells[0].OwningColumn.HeaderText.ToString()
                    + " = "
                    + dataGridView1.CurrentRow.Cells[0].Value.ToString();

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString =
                    "Data Source=GNC-NB122;"
                    + "Initial Catalog= Example ;"
                    + "User id=sa;"
                    + "Password=guncel@123;";
                conn.Open();
                SqlCommand command = new SqlCommand(deleteQuery, conn);
                command.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                if (error.Errors.Count > 0)
                {
                    switch (error.Errors[0].Number)
                    {
                        case 547: // Foreign Key violation
                            dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                            break;
                        default:
                            throw;
                    }
                }
            }
        }

        private void btnCmdInsert_Click(object sender, EventArgs e)
        {
            if (comboTables.SelectedItem != null)
            {
                txtCommand.Text =
                    $"INSERT INTO {comboTables.SelectedItem.ToString()} VALUES (<Value 1>, <Value 2>)";
            }
            else
            {
                txtCommand.Text = "INSERT INTO <Table Name> VALUES (<Value 1>, <Value 2>)";
            }
        }

        private void btnCmdUpdate_Click(object sender, EventArgs e)
        {
            if (comboTables.SelectedItem != null)
            {
                txtCommand.Text =
                    $"UPDATE {comboTables.SelectedItem.ToString()} SET <Column 1 = Value 1>, <Column 2 = Value 2> WHERE ExampleId = ExampleId";
            }
            else
            {
                txtCommand.Text =
                    "UPDATE <Table Name> SET <Column 1 = Value 1>, <Column 2 = Value 2> WHERE ExampleId = ExampleId";
            }
        }

        private void btnCmdDelete_Click(object sender, EventArgs e)
        {
            if (comboTables.SelectedItem != null)
            {
                txtCommand.Text =
                    $"DELETE FROM {comboTables.SelectedItem.ToString()} WHERE ExampleId = ExampleId";
            }
            else
            {
                txtCommand.Text = "DELETE FROM <Table Name> WHERE ExampleId = ExampleId";
            }
        }

        private void checkAuth_CheckedChanged(object sender, EventArgs e)
        {
            conUsername.Enabled = !conUsername.Enabled;
            conPassword.Enabled = !conPassword.Enabled;
            label2.Enabled = !label2.Enabled;
            label3.Enabled = !label3.Enabled;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboTables.SelectedItem != null)
            {
                txtCommand.Text = $"SELECT * FROM {comboTables.SelectedItem.ToString()}";
            }
            else
            {
                txtCommand.Text = "SELECT * FROM <Table Name>";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCommand.Text = "CREATE PROCEDURE <Procedure_Name> AS <Synonyms> GO ";
        }

        private void button6_Click(object sender, EventArgs e) { }

        private void btnUnsellect_Click(object sender, EventArgs e)
        {
            listdb.SelectedIndex = -1;
            DisableGroup(false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source="
                + "."
                + ";"
                + "Initial Catalog= master ;"
                + "User id="
                + "sa"
                + ";"
                + "Password="
                + "guncel@123"
                + ";";
            conn.Open();

            SqlDataAdapter Adapter = new SqlDataAdapter(
                "SELECT * FROM " + comboTables.SelectedItem.ToString() + " ",
                "server = "
                    + conString.Text
                    + "; database = "
                    + listdb.SelectedItem.ToString()
                    + " ; UID = sa; password = guncel@123"
            );
            var dataset = new DataSet();
            Adapter.Fill(dataset);

            MessageBox.Show(dataset.Tables[0].Columns[3].DesignMode.ToString());
        }
    }
}
