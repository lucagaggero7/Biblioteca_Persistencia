﻿using System;

namespace Biblioteca_FE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombredeusuario = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombredeusuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtVerificacion = new System.Windows.Forms.TextBox();
            this.labelVerificacion = new System.Windows.Forms.Label();
            this.errorVerificacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombredeusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVerificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAR USUARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(127, 112);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 25);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(127, 157);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(61, 25);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(127, 309);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(82, 25);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Contraseña";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(127, 206);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(132, 25);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "Nombre de Usuario";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(127, 255);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(54, 25);
            this.labelCorreo.TabIndex = 5;
            this.labelCorreo.Text = "Correo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(299, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 20);
            this.txtNombre.TabIndex = 0;
           
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(299, 158);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(218, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombredeusuario
            // 
            this.txtNombredeusuario.Location = new System.Drawing.Point(299, 207);
            this.txtNombredeusuario.Name = "txtNombredeusuario";
            this.txtNombredeusuario.Size = new System.Drawing.Size(218, 20);
            this.txtNombredeusuario.TabIndex = 2;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(299, 258);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(218, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(299, 309);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(218, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(617, 384);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(96, 36);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorApellido
            // 
            this.errorApellido.ContainerControl = this;
            // 
            // errorNombredeusuario
            // 
            this.errorNombredeusuario.ContainerControl = this;
            // 
            // errorCorreo
            // 
            this.errorCorreo.ContainerControl = this;
            // 
            // errorContraseña
            // 
            this.errorContraseña.ContainerControl = this;
            // 
            // txtVerificacion
            // 
            this.txtVerificacion.Location = new System.Drawing.Point(299, 366);
            this.txtVerificacion.Name = "txtVerificacion";
            this.txtVerificacion.Size = new System.Drawing.Size(218, 20);
            this.txtVerificacion.TabIndex = 5;
        
            // 
            // labelVerificacion
            // 
            this.labelVerificacion.AutoSize = true;
            this.labelVerificacion.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerificacion.Location = new System.Drawing.Point(127, 354);
            this.labelVerificacion.Name = "labelVerificacion";
            this.labelVerificacion.Size = new System.Drawing.Size(153, 50);
            this.labelVerificacion.TabIndex = 14;
            this.labelVerificacion.Text = "Introduzca un numero \r\nentre 10 y 15";
            // 
            // errorVerificacion
            // 
            this.errorVerificacion.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelVerificacion);
            this.Controls.Add(this.txtVerificacion);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombredeusuario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombredeusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVerificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtVerif_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombredeusuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorApellido;
        private System.Windows.Forms.ErrorProvider errorNombredeusuario;
        private System.Windows.Forms.ErrorProvider errorCorreo;
        private System.Windows.Forms.ErrorProvider errorContraseña;
        private System.Windows.Forms.Label labelVerificacion;
        private System.Windows.Forms.TextBox txtVerificacion;
        private System.Windows.Forms.ErrorProvider errorVerificacion;
    }
}

