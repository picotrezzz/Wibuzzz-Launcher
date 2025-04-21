using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class AvatarManager : MonoBehaviour
{
    public Button NoseUp, NoseDown, NoseBig, NoseSmall;
    public int NoseSize;
    public int NosePos;
    public int NoseType = 1;
    public Transform Nose, NoseMesh;

    [Header("Tamaños minimos y maximos")]
    private int maxNoseSize, minNoseSize;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NoseSize = 0;
        NosePos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //NOSE

    public void SetNoseType(int type)
    {
        NoseType = type;
    }

    public void SmallNose()
    {
        NoseSize--;
        NoseMesh.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void BigNose()
    {
        NoseSize++;
        NoseMesh.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void UpNose()
    {
        NosePos++;
        Nose.localPosition += new Vector3(0,0,0.1f);
    }

    public void DownNose()
    {
        NosePos--;
        Nose.localPosition -= new Vector3(0,0,0.1f);
    }

    public void RestartNose()
    {
        NosePos = 0;
        NoseSize = 0;
        Nose.localPosition = new Vector3(0,0,0);
        NoseMesh.localScale = new Vector3(0.15f,0.15f,0.15f);
    }
}
