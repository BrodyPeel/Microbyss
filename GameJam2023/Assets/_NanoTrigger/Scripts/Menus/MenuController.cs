using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static MenuController Instance { get; private set; }

    [SerializeField] private Menu[] menus;
    [SerializeField] private Menu currentMenu;

    public ResultsMenu resultsMenu;

    public ScreenFader screenFader;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Initially show only the Title menu
        ShowMenu(0);
    }

    public void ShowMenu(int menuIndex)
    {
        if(currentMenu != null)
        {
            currentMenu.Close();
        }

        menus[menuIndex].Open();
        currentMenu = menus[menuIndex];
    }

    public void ShowMenu(Menu menu)
    {
        if (currentMenu != null)
        {
            currentMenu.Close();
        }

        menu.Open();
        currentMenu = menu;
    }
}
