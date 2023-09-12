namespace Touhou_Launcher
{
    partial class thcrap
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
            repoList = new System.Windows.Forms.ListView();
            titleColumn = new System.Windows.Forms.ColumnHeader();
            idColumn = new System.Windows.Forms.ColumnHeader();
            gameList = new System.Windows.Forms.ListView();
            gameIDColumn = new System.Windows.Forms.ColumnHeader();
            pathColumn = new System.Windows.Forms.ColumnHeader();
            path = new System.Windows.Forms.TextBox();
            gameID = new System.Windows.Forms.Label();
            gamePath = new System.Windows.Forms.Label();
            gameGroup = new System.Windows.Forms.GroupBox();
            id = new System.Windows.Forms.TextBox();
            removeGame = new System.Windows.Forms.Button();
            addGame = new System.Windows.Forms.Button();
            browsePath = new System.Windows.Forms.Button();
            patchGroup = new System.Windows.Forms.GroupBox();
            patchList = new System.Windows.Forms.ListView();
            patchColumn = new System.Windows.Forms.ColumnHeader();
            descriptionColumn = new System.Windows.Forms.ColumnHeader();
            gameGroup.SuspendLayout();
            patchGroup.SuspendLayout();
            SuspendLayout();
            // 
            // repoList
            // 
            repoList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            repoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { titleColumn, idColumn });
            repoList.FullRowSelect = true;
            repoList.GridLines = true;
            repoList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            repoList.Location = new System.Drawing.Point(7, 22);
            repoList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            repoList.MultiSelect = false;
            repoList.Name = "repoList";
            repoList.ShowItemToolTips = true;
            repoList.Size = new System.Drawing.Size(320, 367);
            repoList.TabIndex = 0;
            repoList.UseCompatibleStateImageBehavior = false;
            repoList.View = System.Windows.Forms.View.Details;
            repoList.SelectedIndexChanged += repoList_SelectedIndexChanged;
            // 
            // titleColumn
            // 
            titleColumn.Name = "titleColumn";
            titleColumn.Text = "Title";
            titleColumn.Width = 175;
            // 
            // idColumn
            // 
            idColumn.Name = "idColumn";
            idColumn.Text = "ID";
            idColumn.Width = 95;
            // 
            // gameList
            // 
            gameList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { gameIDColumn, pathColumn });
            gameList.FullRowSelect = true;
            gameList.GridLines = true;
            gameList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            gameList.Location = new System.Drawing.Point(7, 22);
            gameList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gameList.Name = "gameList";
            gameList.Size = new System.Drawing.Size(320, 132);
            gameList.TabIndex = 0;
            gameList.UseCompatibleStateImageBehavior = false;
            gameList.View = System.Windows.Forms.View.Details;
            gameList.SelectedIndexChanged += gameList_SelectedIndexChanged;
            // 
            // gameIDColumn
            // 
            gameIDColumn.Name = "gameIDColumn";
            gameIDColumn.Text = "Game ID";
            gameIDColumn.Width = 87;
            // 
            // pathColumn
            // 
            pathColumn.Name = "pathColumn";
            pathColumn.Text = "Game Path";
            pathColumn.Width = 183;
            // 
            // path
            // 
            path.Location = new System.Drawing.Point(335, 85);
            path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            path.Name = "path";
            path.Size = new System.Drawing.Size(220, 23);
            path.TabIndex = 2;
            // 
            // gameID
            // 
            gameID.AutoSize = true;
            gameID.Location = new System.Drawing.Point(335, 22);
            gameID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gameID.Name = "gameID";
            gameID.Size = new System.Drawing.Size(55, 15);
            gameID.TabIndex = 5;
            gameID.Text = "Game ID:";
            // 
            // gamePath
            // 
            gamePath.AutoSize = true;
            gamePath.Location = new System.Drawing.Point(335, 67);
            gamePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gamePath.Name = "gamePath";
            gamePath.Size = new System.Drawing.Size(68, 15);
            gamePath.TabIndex = 6;
            gamePath.Text = "Game Path:";
            // 
            // gameGroup
            // 
            gameGroup.Controls.Add(id);
            gameGroup.Controls.Add(removeGame);
            gameGroup.Controls.Add(addGame);
            gameGroup.Controls.Add(browsePath);
            gameGroup.Controls.Add(gamePath);
            gameGroup.Controls.Add(gameList);
            gameGroup.Controls.Add(gameID);
            gameGroup.Controls.Add(path);
            gameGroup.Location = new System.Drawing.Point(10, 418);
            gameGroup.Margin = new System.Windows.Forms.Padding(0);
            gameGroup.Name = "gameGroup";
            gameGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gameGroup.Size = new System.Drawing.Size(657, 162);
            gameGroup.TabIndex = 1;
            gameGroup.TabStop = false;
            gameGroup.Text = "Game Profiles";
            // 
            // id
            // 
            id.Location = new System.Drawing.Point(338, 42);
            id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            id.Name = "id";
            id.Size = new System.Drawing.Size(311, 23);
            id.TabIndex = 1;
            // 
            // removeGame
            // 
            removeGame.Location = new System.Drawing.Point(498, 128);
            removeGame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            removeGame.Name = "removeGame";
            removeGame.Size = new System.Drawing.Size(152, 27);
            removeGame.TabIndex = 5;
            removeGame.Text = "Remove Game";
            removeGame.UseVisualStyleBackColor = true;
            removeGame.Click += removeGame_Click;
            // 
            // addGame
            // 
            addGame.Location = new System.Drawing.Point(338, 128);
            addGame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            addGame.Name = "addGame";
            addGame.Size = new System.Drawing.Size(152, 27);
            addGame.TabIndex = 4;
            addGame.Text = "Add Game";
            addGame.UseVisualStyleBackColor = true;
            addGame.Click += addGame_Click;
            // 
            // browsePath
            // 
            browsePath.Location = new System.Drawing.Point(562, 83);
            browsePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            browsePath.Name = "browsePath";
            browsePath.Size = new System.Drawing.Size(88, 27);
            browsePath.TabIndex = 3;
            browsePath.Text = "Browse";
            browsePath.UseVisualStyleBackColor = true;
            browsePath.Click += browsePath_Click;
            // 
            // patchGroup
            // 
            patchGroup.Controls.Add(patchList);
            patchGroup.Controls.Add(repoList);
            patchGroup.Location = new System.Drawing.Point(10, 10);
            patchGroup.Margin = new System.Windows.Forms.Padding(0);
            patchGroup.Name = "patchGroup";
            patchGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            patchGroup.Size = new System.Drawing.Size(660, 400);
            patchGroup.TabIndex = 0;
            patchGroup.TabStop = false;
            patchGroup.Text = "Custom Profile";
            // 
            // patchList
            // 
            patchList.CheckBoxes = true;
            patchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { patchColumn, descriptionColumn });
            patchList.FullRowSelect = true;
            patchList.GridLines = true;
            patchList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            patchList.Location = new System.Drawing.Point(335, 22);
            patchList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            patchList.MultiSelect = false;
            patchList.Name = "patchList";
            patchList.ShowItemToolTips = true;
            patchList.Size = new System.Drawing.Size(318, 367);
            patchList.TabIndex = 1;
            patchList.UseCompatibleStateImageBehavior = false;
            patchList.View = System.Windows.Forms.View.Details;
            // 
            // patchColumn
            // 
            patchColumn.Name = "patchColumn";
            patchColumn.Text = "Patch";
            patchColumn.Width = 100;
            // 
            // descriptionColumn
            // 
            descriptionColumn.Name = "descriptionColumn";
            descriptionColumn.Text = "Description";
            descriptionColumn.Width = 169;
            // 
            // thcrap
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(681, 591);
            Controls.Add(patchGroup);
            Controls.Add(gameGroup);
            Icon = Properties.Resources.thicon;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "thcrap";
            Text = "Profile Configuration: ";
            FormClosing += thcrap_Closing;
            Load += thcrap_Load;
            gameGroup.ResumeLayout(false);
            gameGroup.PerformLayout();
            patchGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView repoList;
        private System.Windows.Forms.ColumnHeader titleColumn;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ListView gameList;
        private System.Windows.Forms.ColumnHeader gameIDColumn;
        private System.Windows.Forms.ColumnHeader pathColumn;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label gameID;
        private System.Windows.Forms.Label gamePath;
        private System.Windows.Forms.GroupBox gameGroup;
        private System.Windows.Forms.Button removeGame;
        private System.Windows.Forms.Button addGame;
        private System.Windows.Forms.Button browsePath;
        private System.Windows.Forms.GroupBox patchGroup;
        private System.Windows.Forms.ListView patchList;
        private System.Windows.Forms.ColumnHeader patchColumn;
        private System.Windows.Forms.ColumnHeader descriptionColumn;
        private System.Windows.Forms.TextBox id;

    }
}