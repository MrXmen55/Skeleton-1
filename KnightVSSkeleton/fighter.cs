using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

class  fighter
{
    private int health;
    protected PictureBox sprite;




    public fighter(PictureBox sprit)
    {
        this.sprite = sprit;
        this.health = 100;
    }

    public int makeDamage()
    {
        Random random = new Random();
        return random.Next(5, 15);

    }



    virtual protected async void Die()
    {
        sprite.Image = Image.FromFile(@"C:\Users\Mrxmen55\Skeleton-1\Assets\Skeleton_Death.gif");
        await Task.Delay(900);
        sprite.Enabled =false;
    }

    public void ReceiveDamage(int howMuchDamage)
    {
        health = health - howMuchDamage;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }




    public int TellHealth()
    {
        return health;
    }
    public bool isDead()
     {
        if (health <= 0) return true;
        else return false;
     }
    }

