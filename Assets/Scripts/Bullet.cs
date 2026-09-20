using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bullet : MonoBehaviour
{
    [SerializeField] 
    GameObject Projectile;
    [SerializeField]
    Transform spawnPoint;

    [SerializeField]
    float Force = 10f;

    [SerializeField]
    Slider angleSlider;

    [SerializeField]
    TextMeshProUGUI angleText;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             GameObject newProjectile = Instantiate(Projectile, spawnPoint.position, spawnPoint.rotation);
             newProjectile.GetComponent<Rigidbody>().AddForce(spawnPoint.up * Force, ForceMode.Impulse);

            Destroy(newProjectile, 5f);
        }
    }

    public void ChangeAngle()
    {
        transform.rotation = Quaternion.Euler(angleSlider.value, 0, 0);
        angleText.text = "Angulo: " + angleSlider.value.ToString("F1") + "°";
    }
}
