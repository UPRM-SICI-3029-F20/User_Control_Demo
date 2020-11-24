using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Need for StreamReader / StreamWriter

namespace User_Control_Demo
{
    public partial class UserControl_Inventory : UserControl
    {
        // Class variables
        static string[,] dataArrayInventory = null;
        static string[,] saveArrayInventory = null;
        int rows, columns;
        StreamReader inputFile;
        DataGridViewCell currentCell = null;

        public UserControl_Inventory()
        {
            InitializeComponent();
        }

        private void UserControl_Inventory_Load(object sender, EventArgs e)
        {
            // Load CSV File into Array
            // Assumes file is in folder bin/debug
            string filename = "Inventario_Bodega.csv";
            //string filename = "Inventory.xlsx"; // ERROR
            FromFileToArray(ref dataArrayInventory, filename);
            // Create a DGV with the data in dataArray
            arrayToDGV(ref dataArrayInventory, ref dgvInventory);
            dgvInventory.Columns["Codigo"].ReadOnly = true;
            dgvInventory.Columns["Marca"].ReadOnly = true;
            dgvInventory.Columns["Articulo"].ReadOnly = true;
            dgvInventory.Columns["Unidades"].ReadOnly = true;
            dgvInventory.Columns["Costo_Unidad"].ReadOnly = true;

            Btn_SaveChanges.Enabled = false;
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Save reference to current cell
            //currentCell = dgvInventory.CurrentCell;

            //if (currentCell.ColumnIndex.Equals(dgvInventory.Columns["Unidades"].Index))
            //    // Copy text from selected cell to textbox
            //    txtBoxUnits.Text = dgvInventory.CurrentCell.Value.ToString();
            //else
            //    currentCell.Selected = false;

        }


        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {

            // Save reference to current cell
            currentCell = dgvInventory.CurrentCell;

            if (currentCell.ColumnIndex.Equals(dgvInventory.Columns["Unidades"].Index))
            {
                // Copy text from selected cell to textbox
                txtBoxUnits.Text = dgvInventory.CurrentCell.Value.ToString();
                Btn_SaveChanges.Enabled = true;
            }
            else
            {
                currentCell.Selected = false;
                txtBoxUnits.Text = "";
                Btn_SaveChanges.Enabled = false;
            }

        }

        private void Btn_Validate_and_Update(object sender, EventArgs e)
        {
            string newText = txtBoxUnits.Text;
            int newValue = 0;
            bool success = Int32.TryParse(newText, out newValue);
            if (success)
            {
                if (newValue >= 0)
                {
                    currentCell.Value = newValue;
                    MessageBox.Show("Saved: " + newValue);
                } else
                    MessageBox.Show("Please enter non-negative value");
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }

        }


        public void FromFileToArray(ref string[,] dataArray, string filename)
        {

            // READ DATA FROM FILE AND SAVE IN 2-D ARRAY
            try
            {
                // File located in bin/debug
                // Temporarily read all rows into an array 
                string[] allLines = File.ReadAllLines(filename);

                // rows is the same as the length/count of all lines
                rows = allLines.Length;
                // columns is the same as the number of tokens
                columns = allLines[0].Split(',').Length;
                //MessageBox.Show("File has " + rows + " rows and " + columns + " columns");

                inputFile = File.OpenText(filename);
                // Read rows one by one and save into data array 
                // Declare array of "rows"size
                string[] dataRows = new string[rows];
                for (int i = 0; i < dataRows.Length; i++)
                {
                    // Read each row/line
                    dataRows[i] = inputFile.ReadLine();
                }

                // save data from datarow to a 2D Array named dataArray
                dataArray = new string[rows, columns];  // A 2-D array
                string[] dataElements = null;

                // Loop & Process row by row
                for (int i = 0; i < dataRows.Length; i++)
                {
                    dataElements = dataRows[i].Split(',');
                    for (int j = 0; j < dataElements.Length; j++)
                    {
                        dataArray[i, j] = dataElements[j];
                    }
                }

                // Close the file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void arrayToDGV(ref string[,] dataArray, ref DataGridView dgv)
        {
            //Clear all DGV rows
            dgv.Rows.Clear();

            int dataRows = dataArray.GetLength(0); // Length of First Dimension 
            int dataCols = dataArray.GetLength(1); // Length of Second Dimension

            // Add columns with headers & properties from first row
            string colHeader;
            for (int i = 0; i < dataCols; i++)
            {
                colHeader = dataArray[0, i];
                dgv.Columns.Add(colHeader, colHeader);
                //**dgv.Columns[i].DataPropertyName = colHeader;
                //**dgv.Columns[i].HeaderText = colHeader;
            }

            // Assumes row=0 contains headers
            // Populate rows with content beyond 
            for (int row = 1; row < dataRows; row++)
            {
                DataGridViewRow dgvRow = new DataGridViewRow();
                dgvRow.CreateCells(dgv);

                for (int col = 0; col < dataCols; col++)
                {
                    dgvRow.Cells[col].Value = dataArray[row, col];
                }

                dgv.Rows.Add(dgvRow);
            }
        }

        private void Btn_SaveChanges_Click(object sender, EventArgs e)
        {
            // SAVE DATA FROM DGV TO THE FOLLOWING FILE in bin/debug
            // *****************************************************
            string filename = "Inventario_Bodega.csv";
            DGVtoArraytoFile(ref saveArrayInventory, filename, ref dgvInventory);
        }


        public void DGVtoArraytoFile(ref string[,] saveArray, string filename, ref DataGridView dgv)
        {

            saveArray = new string[dgv.RowCount, dgv.ColumnCount];
            string[] saveRow = new string[dgv.RowCount];
            string[] rowElements = new string[dgv.ColumnCount];

            // Get headers
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                saveArray[0, i] = dgv.Columns[i].HeaderText;
            }

            //DataGridViewRow row2 = dgv.Rows[0];

            for (int i = 0; i < dgv.RowCount - 1; i++)
            //foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    saveArray[i + 1, col.Index] =
                       dgv.Rows[i].Cells[col.Index].FormattedValue.ToString().Trim();
                }
            }

            for (int i = 0; i < saveArray.GetLength(0); i++)
            {
                for (int j = 0; j < saveArray.GetLength(1); j++)
                {
                    rowElements[j] = saveArray[i, j];
                }

                saveRow[i] = String.Join(",", rowElements);
            }

            try
            {
                StreamWriter myOutputFile;
                myOutputFile = File.CreateText(filename);

                foreach (string s in saveRow)
                {
                    myOutputFile.WriteLine(s);
                }

                myOutputFile.Close();
                MessageBox.Show("Data Saved to " + filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}
