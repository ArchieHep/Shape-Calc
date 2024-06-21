namespace Shape_Calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_length = new TextBox();
            txt_depth = new TextBox();
            txt_width = new TextBox();
            cmb_Shape = new ComboBox();
            btn_Submit = new Button();
            lbl_length = new Label();
            lbl_width = new Label();
            lbl_depth = new Label();
            lbl_shape = new Label();
            lbl_result = new Label();
            SuspendLayout();
            // 
            // txt_length
            // 
            txt_length.Location = new Point(399, 72);
            txt_length.Name = "txt_length";
            txt_length.Size = new Size(100, 23);
            txt_length.TabIndex = 1;
            // 
            // txt_depth
            // 
            txt_depth.Location = new Point(399, 130);
            txt_depth.Name = "txt_depth";
            txt_depth.Size = new Size(100, 23);
            txt_depth.TabIndex = 3;
            // 
            // txt_width
            // 
            txt_width.Location = new Point(399, 101);
            txt_width.Name = "txt_width";
            txt_width.Size = new Size(100, 23);
            txt_width.TabIndex = 2;
            // 
            // cmb_Shape
            // 
            cmb_Shape.FormattingEnabled = true;
            cmb_Shape.Items.AddRange(new object[] { "Rectangle", "Triangle", "Ellipse", "Cuboid", "Triangular Prism", "Ellipsoid" });
            cmb_Shape.Location = new Point(399, 43);
            cmb_Shape.Name = "cmb_Shape";
            cmb_Shape.Size = new Size(121, 23);
            cmb_Shape.TabIndex = 0;
            cmb_Shape.SelectedIndexChanged += cmb_Shape_SelectedIndexChanged;
            // 
            // btn_Submit
            // 
            btn_Submit.Location = new Point(399, 159);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(75, 23);
            btn_Submit.TabIndex = 4;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // lbl_length
            // 
            lbl_length.AutoSize = true;
            lbl_length.Location = new Point(355, 75);
            lbl_length.Name = "lbl_length";
            lbl_length.Size = new Size(47, 15);
            lbl_length.TabIndex = 5;
            lbl_length.Text = "Length:";
            // 
            // lbl_width
            // 
            lbl_width.AutoSize = true;
            lbl_width.Location = new Point(355, 104);
            lbl_width.Name = "lbl_width";
            lbl_width.Size = new Size(42, 15);
            lbl_width.TabIndex = 6;
            lbl_width.Text = "Width:";
            // 
            // lbl_depth
            // 
            lbl_depth.AutoSize = true;
            lbl_depth.Location = new Point(355, 136);
            lbl_depth.Name = "lbl_depth";
            lbl_depth.Size = new Size(42, 15);
            lbl_depth.TabIndex = 7;
            lbl_depth.Text = "Depth:";
            // 
            // lbl_shape
            // 
            lbl_shape.AutoSize = true;
            lbl_shape.Location = new Point(355, 46);
            lbl_shape.Name = "lbl_shape";
            lbl_shape.Size = new Size(42, 15);
            lbl_shape.TabIndex = 8;
            lbl_shape.Text = "Shape:";
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Location = new Point(355, 190);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(42, 15);
            lbl_result.TabIndex = 9;
            lbl_result.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_result);
            Controls.Add(lbl_shape);
            Controls.Add(lbl_depth);
            Controls.Add(lbl_width);
            Controls.Add(lbl_length);
            Controls.Add(btn_Submit);
            Controls.Add(cmb_Shape);
            Controls.Add(txt_width);
            Controls.Add(txt_depth);
            Controls.Add(txt_length);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_length;
        private TextBox txt_depth;
        private TextBox txt_width;
        private ComboBox cmb_Shape;
        private Button btn_Submit;
        private Label lbl_length;
        private Label lbl_width;
        private Label lbl_depth;
        private Label lbl_shape;
        private Label lbl_result;
    }
}