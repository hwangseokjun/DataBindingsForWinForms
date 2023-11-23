namespace DataBindingsForWinForms.Views
{
    partial class MainView
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
            button1 = new Button();
            mainViewModelBindingSource = new BindingSource(components);
            label1 = new Label();
            checkBox1 = new CheckBox();
            progressBar1 = new ProgressBar();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)mainViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DataBindings.Add(new Binding("Command", mainViewModelBindingSource, "TestACommand", true, DataSourceUpdateMode.OnPropertyChanged));
            button1.Location = new Point(12, 37);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // mainViewModelBindingSource
            // 
            mainViewModelBindingSource.DataSource = typeof(ViewModels.MainViewModel);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.DataBindings.Add(new Binding("Text", mainViewModelBindingSource, "Count", true, DataSourceUpdateMode.OnPropertyChanged));
            label1.Location = new Point(93, 41);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new Binding("Checked", mainViewModelBindingSource, "Enable", true, DataSourceUpdateMode.OnPropertyChanged));
            checkBox1.Location = new Point(12, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.DataBindings.Add(new Binding("Value", mainViewModelBindingSource, "Progress", true, DataSourceUpdateMode.OnPropertyChanged));
            progressBar1.DataBindings.Add(new Binding("DataContext", mainViewModelBindingSource, "MaxProgress", true));
            progressBar1.Location = new Point(12, 71);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(156, 23);
            progressBar1.TabIndex = 3;
            // 
            // button2
            // 
            button2.DataBindings.Add(new Binding("Command", mainViewModelBindingSource, "TestBCommand", true, DataSourceUpdateMode.OnPropertyChanged));
            button2.Location = new Point(12, 100);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.DataBindings.Add(new Binding("Command", mainViewModelBindingSource, "TestBCancelCommand", true, DataSourceUpdateMode.OnPropertyChanged));
            button3.Location = new Point(93, 100);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(progressBar1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "MainView";
            Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)mainViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private CheckBox checkBox1;
        private BindingSource mainViewModelBindingSource;
        private ProgressBar progressBar1;
        private Button button2;
        private Button button3;
    }
}