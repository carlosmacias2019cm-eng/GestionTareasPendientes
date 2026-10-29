namespace GestionTareasPendientes
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
            txtTarea = new TextBox();
            btnAgregarTarea = new Button();
            lstTareas = new ListBox();
            btnEliminarTarea = new Button();
            SuspendLayout();
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(183, 22);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(220, 27);
            txtTarea.TabIndex = 0;
            txtTarea.TextChanged += txtTarea_TextChanged;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.BackColor = Color.SeaGreen;
            btnAgregarTarea.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarTarea.ForeColor = Color.White;
            btnAgregarTarea.Location = new Point(212, 70);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(150, 53);
            btnAgregarTarea.TabIndex = 1;
            btnAgregarTarea.Text = "Agregar Tarea";
            btnAgregarTarea.UseVisualStyleBackColor = false;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // lstTareas
            // 
            lstTareas.BackColor = Color.WhiteSmoke;
            lstTareas.FormattingEnabled = true;
            lstTareas.Location = new Point(155, 129);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(269, 164);
            lstTareas.TabIndex = 2;
            lstTareas.SelectedIndexChanged += lstTareas_SelectedIndexChanged;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.BackColor = Color.Firebrick;
            btnEliminarTarea.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarTarea.ForeColor = Color.White;
            btnEliminarTarea.Location = new Point(212, 299);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(141, 56);
            btnEliminarTarea.TabIndex = 3;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = false;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(582, 453);
            Controls.Add(btnEliminarTarea);
            Controls.Add(lstTareas);
            Controls.Add(btnAgregarTarea);
            Controls.Add(txtTarea);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de tareas pendientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarea;
        private Button btnAgregarTarea;
        private ListBox lstTareas;
        private Button btnEliminarTarea;
    }
}
