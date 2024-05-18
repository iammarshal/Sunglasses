using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Windows.Forms;

namespace PE_PRN211_FA23_1237778_NguyenQuocThien
{
    partial class SunglassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbSunglassesId = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbSunglassesName = new Label();
            textBox3 = new TextBox();
            lbFeature = new Label();
            textBox4 = new TextBox();
            lbMaterial = new Label();
            textBox5 = new TextBox();
            lbShape = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox9 = new TextBox();
            label9 = new Label();
            DGV_Sunglasses = new DataGridView();
            SunglassesId = new DataGridViewTextBoxColumn();
            SunglassesName = new DataGridViewTextBoxColumn();
            Feature = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Shape = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            ManufacturerId = new DataGridViewTextBoxColumn();
            ManufacturerName = new DataGridViewTextBoxColumn();
            manufacturerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)DGV_Sunglasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manufacturerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbSunglassesId
            // 
            lbSunglassesId.AutoSize = true;
            lbSunglassesId.Location = new Point(42, 30);
            lbSunglassesId.Name = "lbSunglassesId";
            lbSunglassesId.Size = new Size(93, 20);
            lbSunglassesId.TabIndex = 0;
            lbSunglassesId.Text = "SunglassesId";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 27);
            textBox2.TabIndex = 3;
            // 
            // lbSunglassesName
            // 
            lbSunglassesName.AutoSize = true;
            lbSunglassesName.Location = new Point(42, 96);
            lbSunglassesName.Name = "lbSunglassesName";
            lbSunglassesName.Size = new Size(120, 20);
            lbSunglassesName.TabIndex = 2;
            lbSunglassesName.Text = "SunglassesName";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(42, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 27);
            textBox3.TabIndex = 5;
            // 
            // lbFeature
            // 
            lbFeature.AutoSize = true;
            lbFeature.Location = new Point(42, 164);
            lbFeature.Name = "lbFeature";
            lbFeature.Size = new Size(58, 20);
            lbFeature.TabIndex = 4;
            lbFeature.Text = "Feature";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(201, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 27);
            textBox4.TabIndex = 7;
            // 
            // lbMaterial
            // 
            lbMaterial.AutoSize = true;
            lbMaterial.Location = new Point(201, 30);
            lbMaterial.Name = "lbMaterial";
            lbMaterial.Size = new Size(64, 20);
            lbMaterial.TabIndex = 6;
            lbMaterial.Text = "Material";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(201, 119);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 27);
            textBox5.TabIndex = 9;
            // 
            // lbShape
            // 
            lbShape.AutoSize = true;
            lbShape.Location = new Point(201, 96);
            lbShape.Name = "lbShape";
            lbShape.Size = new Size(50, 20);
            lbShape.TabIndex = 8;
            lbShape.Text = "Shape";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(201, 187);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(156, 27);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(201, 164);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 10;
            label6.Text = "Price";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(366, 53);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(172, 27);
            textBox7.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(366, 30);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 12;
            label7.Text = "Quantity";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(366, 119);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(172, 27);
            textBox8.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(366, 96);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 14;
            label8.Text = "CreatedDate";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(366, 187);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(172, 27);
            textBox9.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(366, 164);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 16;
            label9.Text = "ManufacturerId";
            // 
            // DGV_Sunglasses
            // 
            DGV_Sunglasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Sunglasses.Columns.AddRange(new DataGridViewColumn[] { SunglassesId, SunglassesName, Feature, Material, Shape, Price, Quantity, CreatedDate, ManufacturerId, ManufacturerName });
            DGV_Sunglasses.Location = new Point(42, 248);
            DGV_Sunglasses.Name = "DGV_Sunglasses";
            DGV_Sunglasses.RowHeadersWidth = 51;
            DGV_Sunglasses.RowTemplate.Height = 29;
            DGV_Sunglasses.Size = new Size(1079, 252);
            DGV_Sunglasses.TabIndex = 18;
            // 
            // SunglassesId
            // 
            SunglassesId.DataPropertyName = "SunglassesId";
            SunglassesId.HeaderText = "SunglassesId";
            SunglassesId.MinimumWidth = 6;
            SunglassesId.Name = "SunglassesId";
            SunglassesId.Width = 125;
            // 
            // SunglassesName
            // 
            SunglassesName.DataPropertyName = "SunglassesName";
            SunglassesName.HeaderText = "SunglassesName";
            SunglassesName.MinimumWidth = 6;
            SunglassesName.Name = "SunglassesName";
            SunglassesName.Width = 125;
            // 
            // Feature
            // 
            Feature.DataPropertyName = "Feature";
            Feature.HeaderText = "Feature";
            Feature.MinimumWidth = 6;
            Feature.Name = "Feature";
            Feature.Width = 125;
            // 
            // Material
            // 
            Material.DataPropertyName = "Material";
            Material.HeaderText = "Material";
            Material.MinimumWidth = 6;
            Material.Name = "Material";
            Material.Width = 125;
            // 
            // Shape
            // 
            Shape.DataPropertyName = "Shape";
            Shape.HeaderText = "Shape";
            Shape.MinimumWidth = 6;
            Shape.Name = "Shape";
            Shape.Width = 125;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.HeaderText = "CreatedDate";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            CreatedDate.Width = 125;
            // 
            // ManufacturerId
            // 
            ManufacturerId.DataPropertyName = "ManufacturerId";
            ManufacturerId.HeaderText = "ManufacturerId";
            ManufacturerId.MinimumWidth = 6;
            ManufacturerId.Name = "ManufacturerId";
            ManufacturerId.Width = 125;
            // 
            // ManufacturerName
            // 
            ManufacturerName.DataPropertyName = "ManufacturerName";
            ManufacturerName.HeaderText = "Manufacturer's Name";
            ManufacturerName.MinimumWidth = 6;
            ManufacturerName.Name = "ManufacturerName";
            ManufacturerName.Width = 125;
            // 
            // manufacturerBindingSource
            // 
            manufacturerBindingSource.DataSource = typeof(Sunglasses_Repository.Models.Manufacturer);
            // 
            // SunglassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 512);
            Controls.Add(DGV_Sunglasses);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(lbShape);
            Controls.Add(textBox4);
            Controls.Add(lbMaterial);
            Controls.Add(textBox3);
            Controls.Add(lbFeature);
            Controls.Add(textBox2);
            Controls.Add(lbSunglassesName);
            Controls.Add(textBox1);
            Controls.Add(lbSunglassesId);
            Name = "SunglassForm";
            Text = "SunglassForm";
            FormClosed += Login_FormClosed;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Sunglasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)manufacturerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSunglassesId;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbSunglassesName;
        private TextBox textBox3;
        private Label lbFeature;
        private TextBox textBox4;
        private Label lbMaterial;
        private TextBox textBox5;
        private Label lbShape;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox9;
        private Label label9;
        private DataGridView DGV_Sunglasses;
        private DataGridViewTextBoxColumn SunglassesId;
        private DataGridViewTextBoxColumn SunglassesName;
        private DataGridViewTextBoxColumn Feature;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Shape;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn ManufacturerId;
        private DataGridViewTextBoxColumn ManufacturerName;
        private BindingSource manufacturerBindingSource;
    }
}