using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public Texture yellow_star;

    private void Start()
    {
        Button[] buttons = this.GetComponentsInChildren<Button>();

        foreach (Button b in buttons) {
            int level = int.Parse(b.name.Substring(5));
            int pass = PlayerPrefs.GetInt(b.name, 0);

            //if curr level is passed
            if (pass == 1)
            {
                //green
                b.image.color = new Color(
                     66.0f / 255f,
                     255.0f / 255f,
                     113.0f / 255f,
                     150f / 255f
                 );
                int n_star = PlayerPrefs.GetInt(b.name + "_n_star", 0);

                RawImage[] stars = b.GetComponentsInChildren<RawImage>();

                for (int i = 0; i < n_star; i++)
                    stars[i].texture = yellow_star;
            }
            else
            {
                if (level <= PlayerPrefs.GetInt("highestLevel", 1))
                {
                    //yellow
                    b.image.color = new Color(
                        255f / 255f,
                        153f / 255f,
                        0 / 255f,
                        150f / 255f
                  );
                }
                else
                {
                    //gray
                  b.image.color = new Color(
                       0,
                       0,
                       0,
                       50f / 255f
                  );
                }
            }
        }


    }


    public AudioSource buttonPress;

    private Button curr;
    public void get_button(Button btn)
    {
        curr = btn;
    }

    public void level_button_Click(int level)
    {
        //dont run new level if the color of button is gray
        if (curr.image.color.r == 0 && curr.image.color.g == 0 && curr.image.color.b == 0 && curr.image.color.a == 50f / 255)
            return;

        buttonPress.Play();
        RedirectToLevel.redirectToLevel = level;
        //load redirectToLevel scene
        SceneManager.LoadScene(3);
    }

    public void back_button_Click()
    {
        //load main scene
        SceneManager.LoadScene(0);
    }
}
