using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    public partial class MainForm : Form
    {
        fighter knight;
        fighter skeleton;

        public MainForm()
        {
            InitializeComponent();
            knight = new fighter(knightPictureBox);
            skeleton = new fighter(skeletonPictureBox);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            skeletonPictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        /// <summary>
        /// После того, как рыцарь и скелет проивзаимодействовали, нужно обновить их здоровье и картинки
        /// </summary>
        public void Update_All()
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skeleton.ReceiveDamage(knight.makeDamage());
            skeletonsHealth.Text = skeleton.TellHealth().ToString();
            if (skeleton.isDead())
            {
                skeletonAttacks.Enabled = false;
                button1.Enabled = false;            }
        }

        private void skeletonAttacks_Click(object sender, EventArgs e)
        {
            knight.ReceiveDamage(skeleton.makeDamage());
            knightsHealth.Text = knight.TellHealth().ToString();
            if (knight.isDead())
            {
                skeletonAttacks.Enabled = false;
                button1.Enabled = false;
            }
        }
    }
}
