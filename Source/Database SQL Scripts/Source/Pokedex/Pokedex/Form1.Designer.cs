namespace Pokedex
{
    partial class Pokedex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokedex));
            this.PokedexList = new System.Windows.Forms.ListBox();
            this.pb_Pokemon = new System.Windows.Forms.PictureBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_typeOne = new System.Windows.Forms.Label();
            this.lbl_typeTwo = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Bug = new System.Windows.Forms.Button();
            this.btn_Dragon = new System.Windows.Forms.Button();
            this.btn_Electric = new System.Windows.Forms.Button();
            this.btn_Fighting = new System.Windows.Forms.Button();
            this.btn_Fire = new System.Windows.Forms.Button();
            this.btn_Flying = new System.Windows.Forms.Button();
            this.btn_Ghost = new System.Windows.Forms.Button();
            this.btn_Grass = new System.Windows.Forms.Button();
            this.btn_Ground = new System.Windows.Forms.Button();
            this.btn_Ice = new System.Windows.Forms.Button();
            this.btn_Normal = new System.Windows.Forms.Button();
            this.btn_Poison = new System.Windows.Forms.Button();
            this.btn_Psychic = new System.Windows.Forms.Button();
            this.btn_Rock = new System.Windows.Forms.Button();
            this.btn_Water = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // PokedexList
            // 
            this.PokedexList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.PokedexList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PokedexList.Cursor = System.Windows.Forms.Cursors.Default;
            this.PokedexList.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokedexList.FormattingEnabled = true;
            this.PokedexList.ItemHeight = 26;
            this.PokedexList.Location = new System.Drawing.Point(296, 378);
            this.PokedexList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PokedexList.Name = "PokedexList";
            this.PokedexList.Size = new System.Drawing.Size(297, 208);
            this.PokedexList.TabIndex = 0;
            this.PokedexList.SelectedIndexChanged += new System.EventHandler(this.PokedexList_SelectedIndexChanged);
            // 
            // pb_Pokemon
            // 
            this.pb_Pokemon.BackColor = System.Drawing.Color.Transparent;
            this.pb_Pokemon.Location = new System.Drawing.Point(307, 59);
            this.pb_Pokemon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_Pokemon.Name = "pb_Pokemon";
            this.pb_Pokemon.Size = new System.Drawing.Size(150, 130);
            this.pb_Pokemon.TabIndex = 1;
            this.pb_Pokemon.TabStop = false;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Description.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(304, 194);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(0, 18);
            this.lbl_Description.TabIndex = 2;
            this.lbl_Description.Click += new System.EventHandler(this.lbl_Description_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(484, 71);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(0, 18);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_typeOne
            // 
            this.lbl_typeOne.AutoSize = true;
            this.lbl_typeOne.BackColor = System.Drawing.Color.Transparent;
            this.lbl_typeOne.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typeOne.Location = new System.Drawing.Point(484, 104);
            this.lbl_typeOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_typeOne.Name = "lbl_typeOne";
            this.lbl_typeOne.Size = new System.Drawing.Size(0, 18);
            this.lbl_typeOne.TabIndex = 6;
            // 
            // lbl_typeTwo
            // 
            this.lbl_typeTwo.AutoSize = true;
            this.lbl_typeTwo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_typeTwo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typeTwo.Location = new System.Drawing.Point(484, 135);
            this.lbl_typeTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_typeTwo.Name = "lbl_typeTwo";
            this.lbl_typeTwo.Size = new System.Drawing.Size(0, 18);
            this.lbl_typeTwo.TabIndex = 7;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(210, 585);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(74, 30);
            this.btn_Reset.TabIndex = 8;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Bug
            // 
            this.btn_Bug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Bug.Location = new System.Drawing.Point(214, 341);
            this.btn_Bug.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Bug.Name = "btn_Bug";
            this.btn_Bug.Size = new System.Drawing.Size(77, 28);
            this.btn_Bug.TabIndex = 9;
            this.btn_Bug.Text = "Bug";
            this.btn_Bug.UseVisualStyleBackColor = false;
            this.btn_Bug.Click += new System.EventHandler(this.btn_Bug_Click);
            // 
            // btn_Dragon
            // 
            this.btn_Dragon.BackColor = System.Drawing.Color.Navy;
            this.btn_Dragon.ForeColor = System.Drawing.Color.White;
            this.btn_Dragon.Location = new System.Drawing.Point(294, 341);
            this.btn_Dragon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dragon.Name = "btn_Dragon";
            this.btn_Dragon.Size = new System.Drawing.Size(78, 28);
            this.btn_Dragon.TabIndex = 10;
            this.btn_Dragon.Text = "Dragon";
            this.btn_Dragon.UseVisualStyleBackColor = false;
            this.btn_Dragon.Click += new System.EventHandler(this.btn_Dragon_Click);
            // 
            // btn_Electric
            // 
            this.btn_Electric.BackColor = System.Drawing.Color.Yellow;
            this.btn_Electric.Location = new System.Drawing.Point(378, 341);
            this.btn_Electric.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Electric.Name = "btn_Electric";
            this.btn_Electric.Size = new System.Drawing.Size(79, 28);
            this.btn_Electric.TabIndex = 11;
            this.btn_Electric.Text = "Electric";
            this.btn_Electric.UseVisualStyleBackColor = false;
            this.btn_Electric.Click += new System.EventHandler(this.btn_Electric_Click);
            // 
            // btn_Fighting
            // 
            this.btn_Fighting.BackColor = System.Drawing.Color.Maroon;
            this.btn_Fighting.ForeColor = System.Drawing.Color.White;
            this.btn_Fighting.Location = new System.Drawing.Point(464, 341);
            this.btn_Fighting.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fighting.Name = "btn_Fighting";
            this.btn_Fighting.Size = new System.Drawing.Size(82, 28);
            this.btn_Fighting.TabIndex = 12;
            this.btn_Fighting.Text = "Fighting";
            this.btn_Fighting.UseVisualStyleBackColor = false;
            this.btn_Fighting.Click += new System.EventHandler(this.btn_Fighting_Click);
            // 
            // btn_Fire
            // 
            this.btn_Fire.BackColor = System.Drawing.Color.Red;
            this.btn_Fire.Location = new System.Drawing.Point(550, 341);
            this.btn_Fire.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fire.Name = "btn_Fire";
            this.btn_Fire.Size = new System.Drawing.Size(71, 28);
            this.btn_Fire.TabIndex = 13;
            this.btn_Fire.Text = "Fire";
            this.btn_Fire.UseVisualStyleBackColor = false;
            this.btn_Fire.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Flying
            // 
            this.btn_Flying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Flying.Location = new System.Drawing.Point(608, 377);
            this.btn_Flying.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Flying.Name = "btn_Flying";
            this.btn_Flying.Size = new System.Drawing.Size(70, 28);
            this.btn_Flying.TabIndex = 14;
            this.btn_Flying.Text = "Flying";
            this.btn_Flying.UseVisualStyleBackColor = false;
            this.btn_Flying.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Ghost
            // 
            this.btn_Ghost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Ghost.Location = new System.Drawing.Point(608, 405);
            this.btn_Ghost.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ghost.Name = "btn_Ghost";
            this.btn_Ghost.Size = new System.Drawing.Size(70, 28);
            this.btn_Ghost.TabIndex = 15;
            this.btn_Ghost.Text = "Ghost";
            this.btn_Ghost.UseVisualStyleBackColor = false;
            this.btn_Ghost.Click += new System.EventHandler(this.btn_Ghost_Click);
            // 
            // btn_Grass
            // 
            this.btn_Grass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Grass.Location = new System.Drawing.Point(608, 434);
            this.btn_Grass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Grass.Name = "btn_Grass";
            this.btn_Grass.Size = new System.Drawing.Size(70, 28);
            this.btn_Grass.TabIndex = 16;
            this.btn_Grass.Text = "Grass";
            this.btn_Grass.UseVisualStyleBackColor = false;
            this.btn_Grass.Click += new System.EventHandler(this.btn_Grass_Click);
            // 
            // btn_Ground
            // 
            this.btn_Ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Ground.Location = new System.Drawing.Point(608, 462);
            this.btn_Ground.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ground.Name = "btn_Ground";
            this.btn_Ground.Size = new System.Drawing.Size(70, 28);
            this.btn_Ground.TabIndex = 17;
            this.btn_Ground.Text = "Ground";
            this.btn_Ground.UseVisualStyleBackColor = false;
            this.btn_Ground.Click += new System.EventHandler(this.btn_Ground_Click);
            // 
            // btn_Ice
            // 
            this.btn_Ice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Ice.Location = new System.Drawing.Point(608, 490);
            this.btn_Ice.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ice.Name = "btn_Ice";
            this.btn_Ice.Size = new System.Drawing.Size(70, 28);
            this.btn_Ice.TabIndex = 18;
            this.btn_Ice.Text = "Ice";
            this.btn_Ice.UseVisualStyleBackColor = false;
            this.btn_Ice.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_Normal
            // 
            this.btn_Normal.Location = new System.Drawing.Point(608, 518);
            this.btn_Normal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Normal.Name = "btn_Normal";
            this.btn_Normal.Size = new System.Drawing.Size(70, 28);
            this.btn_Normal.TabIndex = 19;
            this.btn_Normal.Text = "Normal";
            this.btn_Normal.UseVisualStyleBackColor = true;
            this.btn_Normal.Click += new System.EventHandler(this.btn_Normal_Click);
            // 
            // btn_Poison
            // 
            this.btn_Poison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Poison.Location = new System.Drawing.Point(608, 546);
            this.btn_Poison.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Poison.Name = "btn_Poison";
            this.btn_Poison.Size = new System.Drawing.Size(70, 28);
            this.btn_Poison.TabIndex = 20;
            this.btn_Poison.Text = "Poison";
            this.btn_Poison.UseVisualStyleBackColor = false;
            this.btn_Poison.Click += new System.EventHandler(this.btn_Poison_Click);
            // 
            // btn_Psychic
            // 
            this.btn_Psychic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Psychic.Location = new System.Drawing.Point(608, 574);
            this.btn_Psychic.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Psychic.Name = "btn_Psychic";
            this.btn_Psychic.Size = new System.Drawing.Size(70, 28);
            this.btn_Psychic.TabIndex = 21;
            this.btn_Psychic.Text = "Psychic";
            this.btn_Psychic.UseVisualStyleBackColor = false;
            this.btn_Psychic.Click += new System.EventHandler(this.btn_Psychic_Click);
            // 
            // btn_Rock
            // 
            this.btn_Rock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Rock.Location = new System.Drawing.Point(523, 601);
            this.btn_Rock.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Rock.Name = "btn_Rock";
            this.btn_Rock.Size = new System.Drawing.Size(70, 28);
            this.btn_Rock.TabIndex = 22;
            this.btn_Rock.Text = "Rock";
            this.btn_Rock.UseVisualStyleBackColor = false;
            this.btn_Rock.Click += new System.EventHandler(this.btn_Rock_Click);
            // 
            // btn_Water
            // 
            this.btn_Water.BackColor = System.Drawing.Color.Cyan;
            this.btn_Water.Location = new System.Drawing.Point(445, 602);
            this.btn_Water.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Water.Name = "btn_Water";
            this.btn_Water.Size = new System.Drawing.Size(70, 27);
            this.btn_Water.TabIndex = 23;
            this.btn_Water.Text = "Water";
            this.btn_Water.UseVisualStyleBackColor = false;
            this.btn_Water.Click += new System.EventHandler(this.btn_Water_Click);
            // 
            // Pokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1193, 816);
            this.Controls.Add(this.btn_Water);
            this.Controls.Add(this.btn_Rock);
            this.Controls.Add(this.btn_Psychic);
            this.Controls.Add(this.btn_Poison);
            this.Controls.Add(this.btn_Normal);
            this.Controls.Add(this.btn_Ice);
            this.Controls.Add(this.btn_Ground);
            this.Controls.Add(this.btn_Grass);
            this.Controls.Add(this.btn_Ghost);
            this.Controls.Add(this.btn_Flying);
            this.Controls.Add(this.btn_Fire);
            this.Controls.Add(this.btn_Fighting);
            this.Controls.Add(this.btn_Electric);
            this.Controls.Add(this.btn_Dragon);
            this.Controls.Add(this.btn_Bug);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_typeTwo);
            this.Controls.Add(this.lbl_typeOne);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.pb_Pokemon);
            this.Controls.Add(this.PokedexList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pokedex";
            this.Text = "Pokedex";
            this.TransparencyKey = System.Drawing.Color.White;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pokedex_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pokedex_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pokedex_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PokedexList;
        private System.Windows.Forms.PictureBox pb_Pokemon;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_typeOne;
        private System.Windows.Forms.Label lbl_typeTwo;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Bug;
        private System.Windows.Forms.Button btn_Dragon;
        private System.Windows.Forms.Button btn_Electric;
        private System.Windows.Forms.Button btn_Fighting;
        private System.Windows.Forms.Button btn_Fire;
        private System.Windows.Forms.Button btn_Flying;
        private System.Windows.Forms.Button btn_Ghost;
        private System.Windows.Forms.Button btn_Grass;
        private System.Windows.Forms.Button btn_Ground;
        private System.Windows.Forms.Button btn_Ice;
        private System.Windows.Forms.Button btn_Normal;
        private System.Windows.Forms.Button btn_Poison;
        private System.Windows.Forms.Button btn_Psychic;
        private System.Windows.Forms.Button btn_Rock;
        private System.Windows.Forms.Button btn_Water;
    }
}

