using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class AvatarManager : MonoBehaviour
{
    [Header("Ojos")]
    public Button EyesUp;
    public Button EyesDown;
    public Button EyesBig;
    public Button EyesSmall;
    public Button EyesTiltUp;
    public Button EyesTiltDown;
    public Transform REye;
    public Transform LEye;
    public Transform bothEyes;
    public float EyePos;
    public float EyeRot;
    public float EyeSeparation;
    public float EyeSize;
    public int EyeType;
    [Header("Nariz")]
    public Button NoseUp;
    public Button NoseDown;
    public Button NoseBig;
    public Button NoseSmall;
    public float NoseSize;
    public float NosePos;
    public int NoseType = 1;
    //PARTES
    public Transform Nose, NoseMesh;
    //AVATAR ENTERO
    [Header("Avatar Entero")]
    public Slider RotatorAvatarSlider;
    public Transform AvatarRotator;

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
        AvatarRotator.localRotation = Quaternion.Euler(0, RotatorAvatarSlider.value, 0);
    }

    //EYES
    public void SetEyesType(int type)
    {
        EyeType = type;
    }

    public void SmallEyes()
    {
        EyeSize-=1f;
        REye.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        LEye.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void BigEye()
    {
        EyeSize+=1;
        REye.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        LEye.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void SeparateEyes()
    {
        LEye.localPosition -= new Vector3(0, 0.1f, 0);
        REye.localPosition += new Vector3(0, 0.1f, 0);
    }

    public void SquintEyes()
    {
        LEye.localPosition += new Vector3(0, 0.1f, 0);
        REye.localPosition -= new Vector3(0, 0.1f, 0);
    }

    public void UpEyes()
    {
        EyePos+=0.5f;
        bothEyes.localPosition += new Vector3(0,0.05f,0);
    }

    public void DownEyes()
    {
        EyePos-=0.5f;
        bothEyes.localPosition -= new Vector3(0,0.05f,0);
    }

    public void RestartEyes()
    {
        EyePos = 0;
        EyeSize = 0;
        bothEyes.localPosition = new Vector3(0,0,0);
        REye.localScale = new Vector3(1,1,1);
        LEye.localScale = new Vector3(1,1,1);
        LEye.localPosition = new Vector3(0, -0.74f, 0);
        REye.localPosition = new Vector3(0, 0.74f, 0);
    }

    //NOSE

    public void SetNoseType(int type)
    {
        NoseType = type;
    }

    public void SmallNose()
    {
        NoseSize-=0.5f;
        NoseMesh.localScale -= new Vector3(0.05f, 0.05f, 0.05f);
    }

    public void BigNose()
    {
        NoseSize+=0.5f;
        NoseMesh.localScale += new Vector3(0.05f, 0.05f, 0.05f);
    }

    public void UpNose()
    {
        NosePos+=0.5f;
        Nose.localPosition += new Vector3(0,0,0.05f);
    }

    public void DownNose()
    {
        NosePos-=0.5f;
        Nose.localPosition -= new Vector3(0,0,0.05f);
    }

    public void RestartNose()
    {
        NosePos = 0;
        NoseSize = 0;
        Nose.localPosition = new Vector3(0,0,0);
        NoseMesh.localScale = new Vector3(0.15f,0.15f,0.15f);
    }
}
