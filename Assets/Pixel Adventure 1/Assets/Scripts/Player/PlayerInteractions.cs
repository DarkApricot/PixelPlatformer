using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private Transform pos;
    private Rigidbody2D rb;

    //Level swap
    public bool level1To2;
    public bool level2To3;
    public bool level3To4;
    public bool level4To5;

    //lvl 1

    //Cave
    public bool caveInteractEntrance;
    public bool caveInteractExit;

    //Button
    public bool isTouched;
    [SerializeField] public bool summonStairs = false;


    //Lvl2

    //borders
    private float xPosRightBorder = 51.30f;
    private float xPosLeftBorder = -18.40f;
    public bool touchedLeft;
    public bool touchedRight;

    //paper
    public bool pressH;
    public bool openPaper;

    //whenStuck
    public bool whenStuck;

    //Lvl 3

    //popups
    public bool curtainsPopup;
    public bool stairsPopup;
    public bool keyPopup;
    public bool doorPopup;
    public bool glass;

    //Camera
    public int floor;
    public bool wallTouched;

    //clock
    public bool openGlass;
    public bool grabKey;
    public bool doorOpen;

    private ConnectingPadlock padlock;
    public bool stairsAnim;


    private void Start()
    {
        pos = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        padlock = FindObjectOfType<ConnectingPadlock>();
    }
    private void Update()
    {
        if (pressH == true && Input.GetKeyDown(KeyCode.H))
        {
            openPaper = true;
        }

        if (openPaper == true && Input.GetKeyDown(KeyCode.B))
        {
            openPaper = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CameraWall"))
        {
            wallTouched = false;
        }

        if (collision.gameObject.CompareTag("Curtains"))
        {
            curtainsPopup = false;
        }

        if (collision.gameObject.CompareTag("Stairs"))
        {
            stairsPopup = false;
        }

        if (collision.gameObject.CompareTag("Glass"))
        {
            glass = false;
        }

        if (collision.gameObject.CompareTag("Key"))
        {
            keyPopup = false;
        }

        if (collision.gameObject.CompareTag("pressH"))
        {
            pressH = false;
        }
        if (collision.gameObject.CompareTag("underground"))
        {
            whenStuck = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Cave lvl 1
        if (collision.gameObject.CompareTag("CaveEntrance") && Input.GetKeyUp("space"))
        {
            pos.position = new Vector3(-53.6f, -108.4f, pos.position.z);
        }
        if (collision.gameObject.CompareTag("CaveExit") && Input.GetKeyDown("space"))
        {
            pos.position = new Vector3(39.3f, 11.7f, pos.position.z);
        }

        //lvl 2
        if (collision.gameObject.CompareTag("pressH"))
        {
            pressH = true;
        }

        if (collision.gameObject.CompareTag("underground"))
        {
            whenStuck = true;
        }





        //Camera lvl 3
        if (collision.gameObject.CompareTag("CameraWall"))
        {
            wallTouched = true;
        }

        //Curtains lvl 3
        if (collision.gameObject.CompareTag("Curtains"))
        {
            curtainsPopup = true;
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                curtainsPopup = false;
                stairsAnim = true;
            }
        }

        //key && glass lvl 3
        if (collision.gameObject.CompareTag("Key"))
        {
            keyPopup = true;
            if (Input.GetKeyDown(KeyCode.H) && padlock.deleteGlass == true)
            {
                grabKey = true;
            }
        }
        else
        {
            keyPopup = false;
        }
        if (collision.gameObject.CompareTag("Glass"))
        {
            glass = true;
            if (Input.GetKeyDown(KeyCode.H) && padlock.deleteGlass == false)
            {
                openGlass = true;
            }
        }
        if (collision.gameObject.CompareTag("DoorLvl3") && grabKey == true)
        {
            doorPopup = true;
            if (Input.GetKeyDown(KeyCode.H))
            {
                doorPopup = false;
                doorOpen = true;
            }
        }
        else
        {
            doorPopup = false;
        }

        //Stairs lvl 3
        if (collision.gameObject.CompareTag("Stairs"))
        {
            stairsPopup = true;
            if (Input.GetKeyDown(KeyCode.W) && pos.position.y > 20)
            {
                floor = 1;
                stairsPopup = false;
                pos.position = new Vector3(9.19f, 17.79f, pos.position.z);
            }
            else if (Input.GetKeyDown(KeyCode.W) && pos.position.y < 20)
            {
                floor = 2;
                stairsPopup = false;
                pos.position = new Vector3(-3.37f, 33.82f, pos.position.z);
            }
            else
            {
                floor = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //lvl2
        if (collision.gameObject.CompareTag("LeftBorder"))
        {
            pos.position = new Vector3(xPosRightBorder, pos.position.y, pos.position.z);

        }
        if (collision.gameObject.CompareTag("RightBorder"))
        {
            pos.position = new Vector3(xPosLeftBorder, pos.position.y, pos.position.z);
        }

      

        //fan
        if (collision.gameObject.CompareTag("Fan"))
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + 23f);
        }
        if (collision.gameObject.CompareTag("FanxButton") && summonStairs == true) //The fan that's connected to the button, and if the button is pressed
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + 25f);
        }



        //Button
        if (collision.gameObject.CompareTag("Button"))
        {
            isTouched = true;
            summonStairs = true;
        }

        //Level Swap
        if (collision.gameObject.CompareTag("Lvl1Exit"))
        {
            level1To2 = true;
        }
        if (collision.gameObject.CompareTag("Lvl2Exit"))
        {
            level2To3 = true;
        }
        if (collision.gameObject.CompareTag("Lvl3Exit"))
        {
            level3To4 = true;
        }
        if (collision.gameObject.CompareTag("Lvl4Exit"))
        {
            level4To5 = true;
        }
    }

}
