using UnityEngine;
using UnityEngine.UI;

public class Skin_Taylor : MonoBehaviour
{
    public GameObject Gen1;
    public Sprite TextureA;
    public Sprite TextureB;
    void Update()
    {
        if(GameEvents.clicks >= Generate.TaylorCost)
        {
            Gen1.GetComponent<Image>().sprite = TextureA;
        }else
        {
            Gen1.GetComponent<Image>().sprite = TextureB;
        }
    }
}
