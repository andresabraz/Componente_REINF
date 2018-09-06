﻿namespace REINF_CSharp
{
    partial class frmReinf
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCNPJSH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTokenSH = new System.Windows.Forms.TextBox();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.cbbCertificado = new System.Windows.Forms.ComboBox();
            this.btnCarregaTx2 = new System.Windows.Forms.Button();
            this.btnGerarXML = new System.Windows.Forms.Button();
            this.btnAssinar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIDLote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmpregador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAmbiente = new System.Windows.Forms.ComboBox();
            this.cbVersao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTemplates = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEsquemas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbRetorno = new System.Windows.Forms.TextBox();
            this.tbXmlEnvio = new System.Windows.Forms.TextBox();
            this.tbXmlRetorno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNrRecibo = new System.Windows.Forms.RadioButton();
            this.rbIdEvento = new System.Windows.Forms.RadioButton();
            this.rbIdLote = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF / CNPJ Software House:";
            // 
            // tbCNPJSH
            // 
            this.tbCNPJSH.Location = new System.Drawing.Point(12, 25);
            this.tbCNPJSH.Name = "tbCNPJSH";
            this.tbCNPJSH.Size = new System.Drawing.Size(216, 20);
            this.tbCNPJSH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Token Software House:";
            // 
            // tbTokenSH
            // 
            this.tbTokenSH.Location = new System.Drawing.Point(238, 25);
            this.tbTokenSH.Name = "tbTokenSH";
            this.tbTokenSH.Size = new System.Drawing.Size(293, 20);
            this.tbTokenSH.TabIndex = 3;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(12, 208);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(519, 24);
            this.btnConfigurar.TabIndex = 4;
            this.btnConfigurar.Text = "Configurar Componente";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurarSH_Click);
            // 
            // cbbCertificado
            // 
            this.cbbCertificado.FormattingEnabled = true;
            this.cbbCertificado.Location = new System.Drawing.Point(12, 181);
            this.cbbCertificado.Name = "cbbCertificado";
            this.cbbCertificado.Size = new System.Drawing.Size(519, 21);
            this.cbbCertificado.TabIndex = 5;
            // 
            // btnCarregaTx2
            // 
            this.btnCarregaTx2.Location = new System.Drawing.Point(12, 238);
            this.btnCarregaTx2.Name = "btnCarregaTx2";
            this.btnCarregaTx2.Size = new System.Drawing.Size(112, 23);
            this.btnCarregaTx2.TabIndex = 6;
            this.btnCarregaTx2.Text = "Carrega Tx2";
            this.btnCarregaTx2.UseVisualStyleBackColor = true;
            this.btnCarregaTx2.Click += new System.EventHandler(this.btnCarregaTx2_Click);
            // 
            // btnGerarXML
            // 
            this.btnGerarXML.Location = new System.Drawing.Point(130, 238);
            this.btnGerarXML.Name = "btnGerarXML";
            this.btnGerarXML.Size = new System.Drawing.Size(132, 23);
            this.btnGerarXML.TabIndex = 8;
            this.btnGerarXML.Text = "Gerar XML";
            this.btnGerarXML.UseVisualStyleBackColor = true;
            this.btnGerarXML.Click += new System.EventHandler(this.btnGerarXML_Click);
            // 
            // btnAssinar
            // 
            this.btnAssinar.Location = new System.Drawing.Point(268, 238);
            this.btnAssinar.Name = "btnAssinar";
            this.btnAssinar.Size = new System.Drawing.Size(132, 23);
            this.btnAssinar.TabIndex = 9;
            this.btnAssinar.Text = "Assinar";
            this.btnAssinar.UseVisualStyleBackColor = true;
            this.btnAssinar.Click += new System.EventHandler(this.btnAssinar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(406, 238);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(125, 23);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 327);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(519, 23);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Identificador do Lote";
            // 
            // tbIDLote
            // 
            this.tbIDLote.Location = new System.Drawing.Point(12, 369);
            this.tbIDLote.Name = "tbIDLote";
            this.tbIDLote.Size = new System.Drawing.Size(519, 20);
            this.tbIDLote.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Certificados:";
            // 
            // tbEmpregador
            // 
            this.tbEmpregador.Location = new System.Drawing.Point(12, 67);
            this.tbEmpregador.Name = "tbEmpregador";
            this.tbEmpregador.Size = new System.Drawing.Size(160, 20);
            this.tbEmpregador.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "CPF / CNPJ Empregador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ambiente:";
            // 
            // cbAmbiente
            // 
            this.cbAmbiente.FormattingEnabled = true;
            this.cbAmbiente.Items.AddRange(new object[] {
            "1 - Produção",
            "2 - Homologação"});
            this.cbAmbiente.Location = new System.Drawing.Point(178, 67);
            this.cbAmbiente.Name = "cbAmbiente";
            this.cbAmbiente.Size = new System.Drawing.Size(173, 21);
            this.cbAmbiente.TabIndex = 18;
            // 
            // cbVersao
            // 
            this.cbVersao.FormattingEnabled = true;
            this.cbVersao.Items.AddRange(new object[] {
            "vm13"});
            this.cbVersao.Location = new System.Drawing.Point(358, 67);
            this.cbVersao.Name = "cbVersao";
            this.cbVersao.Size = new System.Drawing.Size(173, 21);
            this.cbVersao.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Versão Manual:";
            // 
            // tbTemplates
            // 
            this.tbTemplates.Location = new System.Drawing.Point(12, 107);
            this.tbTemplates.Name = "tbTemplates";
            this.tbTemplates.Size = new System.Drawing.Size(519, 20);
            this.tbTemplates.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Caminho Templates:";
            // 
            // tbEsquemas
            // 
            this.tbEsquemas.Location = new System.Drawing.Point(12, 144);
            this.tbEsquemas.Name = "tbEsquemas";
            this.tbEsquemas.Size = new System.Drawing.Size(519, 20);
            this.tbEsquemas.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Caminho Esquemas:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(538, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 382);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbRetorno);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Retorno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbXmlEnvio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xml de Envio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbXmlRetorno);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(529, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xml de Retorno";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbRetorno
            // 
            this.tbRetorno.Location = new System.Drawing.Point(4, 3);
            this.tbRetorno.Multiline = true;
            this.tbRetorno.Name = "tbRetorno";
            this.tbRetorno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRetorno.Size = new System.Drawing.Size(519, 347);
            this.tbRetorno.TabIndex = 8;
            // 
            // tbXmlEnvio
            // 
            this.tbXmlEnvio.Location = new System.Drawing.Point(5, 5);
            this.tbXmlEnvio.Multiline = true;
            this.tbXmlEnvio.Name = "tbXmlEnvio";
            this.tbXmlEnvio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbXmlEnvio.Size = new System.Drawing.Size(519, 347);
            this.tbXmlEnvio.TabIndex = 9;
            // 
            // tbXmlRetorno
            // 
            this.tbXmlRetorno.Location = new System.Drawing.Point(5, 5);
            this.tbXmlRetorno.Multiline = true;
            this.tbXmlRetorno.Name = "tbXmlRetorno";
            this.tbXmlRetorno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbXmlRetorno.Size = new System.Drawing.Size(519, 347);
            this.tbXmlRetorno.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNrRecibo);
            this.groupBox1.Controls.Add(this.rbIdEvento);
            this.groupBox1.Controls.Add(this.rbIdLote);
            this.groupBox1.Location = new System.Drawing.Point(12, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 54);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Consulta:";
            // 
            // rbNrRecibo
            // 
            this.rbNrRecibo.AutoSize = true;
            this.rbNrRecibo.Location = new System.Drawing.Point(441, 24);
            this.rbNrRecibo.Name = "rbNrRecibo";
            this.rbNrRecibo.Size = new System.Drawing.Size(76, 17);
            this.rbNrRecibo.TabIndex = 31;
            this.rbNrRecibo.TabStop = true;
            this.rbNrRecibo.Text = "Nr. Recibo";
            this.rbNrRecibo.UseVisualStyleBackColor = true;
            // 
            // rbIdEvento
            // 
            this.rbIdEvento.AutoSize = true;
            this.rbIdEvento.Location = new System.Drawing.Point(217, 24);
            this.rbIdEvento.Name = "rbIdEvento";
            this.rbIdEvento.Size = new System.Drawing.Size(86, 17);
            this.rbIdEvento.TabIndex = 30;
            this.rbIdEvento.TabStop = true;
            this.rbIdEvento.Text = "Id de Evento";
            this.rbIdEvento.UseVisualStyleBackColor = true;
            // 
            // rbIdLote
            // 
            this.rbIdLote.AutoSize = true;
            this.rbIdLote.Location = new System.Drawing.Point(7, 24);
            this.rbIdLote.Name = "rbIdLote";
            this.rbIdLote.Size = new System.Drawing.Size(69, 17);
            this.rbIdLote.TabIndex = 29;
            this.rbIdLote.TabStop = true;
            this.rbIdLote.Text = "Id de lote";
            this.rbIdLote.UseVisualStyleBackColor = true;
            // 
            // frmReinf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbEsquemas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTemplates);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbVersao);
            this.Controls.Add(this.cbAmbiente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmpregador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIDLote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnAssinar);
            this.Controls.Add(this.btnGerarXML);
            this.Controls.Add(this.btnCarregaTx2);
            this.Controls.Add(this.cbbCertificado);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.tbTokenSH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCNPJSH);
            this.Controls.Add(this.label1);
            this.Name = "frmReinf";
            this.Text = "Demo REINF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCNPJSH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTokenSH;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.ComboBox cbbCertificado;
        private System.Windows.Forms.Button btnCarregaTx2;
        private System.Windows.Forms.Button btnGerarXML;
        private System.Windows.Forms.Button btnAssinar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIDLote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmpregador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAmbiente;
        private System.Windows.Forms.ComboBox cbVersao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTemplates;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEsquemas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbRetorno;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbXmlEnvio;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbXmlRetorno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNrRecibo;
        private System.Windows.Forms.RadioButton rbIdEvento;
        private System.Windows.Forms.RadioButton rbIdLote;
    }
}

