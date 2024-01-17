using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class LevelChoose : MonoBehaviour
{

    public TextMeshProUGUI quizOneScore;
    public TextMeshProUGUI quizTwoScore;
    public TextMeshProUGUI quizThreeScore;
    public TextMeshProUGUI quizFourScore;
    public TextMeshProUGUI quizTotal;

    public TextMeshProUGUI forestStarsTotal;
    public TextMeshProUGUI caveStarsTotal;
    public TextMeshProUGUI dungeonStarsTotal;
    public TextMeshProUGUI mountainStarsTotal;

    // Forest: Level 1
    public GameObject forestOneOne;
    public GameObject forestOneTwo;
    public GameObject forestOneThree;

    // Forest: Level 2
    public GameObject forestTwoOne;
    public GameObject forestTwoTwo;
    public GameObject forestTwoThree;

    // Forest: Level 3
    public GameObject forestThreeOne;
    public GameObject forestThreeTwo;
    public GameObject forestThreeThree;

    // Forest: Level 4
    public GameObject forestFourOne;
    public GameObject forestFourTwo;
    public GameObject forestFourThree;

    // Forest: Level 5
    public GameObject forestFiveOne;
    public GameObject forestFiveTwo;
    public GameObject forestFiveThree;

    // ======================================

    // Cave: Level 1
    public GameObject caveOneOne;
    public GameObject caveOneTwo;
    public GameObject caveOneThree;

    // Cave: Level 2
    public GameObject caveTwoOne;
    public GameObject caveTwoTwo;
    public GameObject caveTwoThree;

    // Cave: Level 3
    public GameObject caveThreeOne;
    public GameObject caveThreeTwo;
    public GameObject caveThreeThree;

    // Cave: Level 4
    public GameObject caveFourOne;
    public GameObject caveFourTwo;
    public GameObject caveFourThree;

    // Cave: Level 5
    public GameObject caveFiveOne;
    public GameObject caveFiveTwo;
    public GameObject caveFiveThree;

    // ======================================

    // Dungeon: Level 1
    public GameObject dungeonOneOne;
    public GameObject dungeonOneTwo;
    public GameObject dungeonOneThree;

    // Dungeon: Level 2
    public GameObject dungeonTwoOne;
    public GameObject dungeonTwoTwo;
    public GameObject dungeonTwoThree;

    // Dungeon: Level 3
    public GameObject dungeonThreeOne;
    public GameObject dungeonThreeTwo;
    public GameObject dungeonThreeThree;

    // Dungeon: Level 4
    public GameObject dungeonFourOne;
    public GameObject dungeonFourTwo;
    public GameObject dungeonFourThree;

    // Dungeon: Level 5
    public GameObject dungeonFiveOne;
    public GameObject dungeonFiveTwo;
    public GameObject dungeonFiveThree;

    // ======================================

    // Mountain: Level 1
    public GameObject mountainOneOne;
    public GameObject mountainOneTwo;
    public GameObject mountainOneThree;

    // Mountain: Level 2
    public GameObject mountainTwoOne;
    public GameObject mountainTwoTwo;
    public GameObject mountainTwoThree;

    // Mountain: Level 3
    public GameObject mountainThreeOne;
    public GameObject mountainThreeTwo;
    public GameObject mountainThreeThree;

    // Mountain: Level 4
    public GameObject mountainFourOne;
    public GameObject mountainFourTwo;
    public GameObject mountainFourThree;

    // Mountain: Level 5
    public GameObject mountainFiveOne;
    public GameObject mountainFiveTwo;
    public GameObject mountainFiveThree;

    public Button arcTwo;
    public Button arcThree;
    public Button arcFour;

    public GameObject arcTwoLock;
    public GameObject arcThreeLock;
    public GameObject arcFourLock;

    public void Test() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); }

    public void ForestLevelOne() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5); }

    public void ForestLevelTwo() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6); }

    public void ForestLevelThree() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7); }

    public void ForestLevelFour() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8); }

    public void ForestLevelFive() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9); }

    public void CaveLevelOne() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10); }

    public void CaveLevelTwo() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11); }

    public void CaveLevelThree() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12); }

    public void CaveLevelFour() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13); }

    public void CaveLevelFive() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 14); }

    public void DungeonLevelOne() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15); }

    public void DungeonLevelTwo() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 16); }

    public void DungeonLevelThree() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 17); }

    public void DungeonLevelFour() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 18); }

    public void DungeonLevelFive() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 19); }

    public void MountainLevelOne() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 20); }

    public void MountainLevelTwo() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 21); }

    public void MountainLevelThree() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 22); }

    public void MountainLevelFour() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 23); }

    public void MountainLevelFive() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 24); }

    public void ForestLevelOneToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }

    public void ForestLevelTwoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }

    public void ForestLevelThreeToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }

    public void ForestLevelFourToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }

    public void ForestLevelFiveToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }

    public void CaveLevelOneToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }

    public void CaveLevelTwoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);
    }

    public void CaveLevelThreeToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 12);
    }

    public void CaveLevelFourToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 13);
    }

    public void CaveLevelFiveToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 14);
    }

    public void DungeonLevelOneToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 15);
    }

    public void DungeonLevelTwoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 16);
    }

    public void DungeonLevelThreeToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 17);
    }

    public void DungeonLevelFourToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 18);
    }

    public void DungeonLevelFiveToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 19);
    }

    public void MountainLevelOneToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 20);
    }

    public void MountainLevelTwoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 21);
    }

    public void MountainLevelThreeToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 22);
    }

    public void MountainLevelFourToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 23);
    }

    public void MountainLevelFiveToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 24);
    }

    public void ForestLevelClearNextLevel()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowAllStars()
    {
        int scoreOne = PlayerPrefs.GetInt("ForestOneScore");
        int scoreTwo = PlayerPrefs.GetInt("ForestTwoScore");
        int scoreThree = PlayerPrefs.GetInt("ForestThreeScore");
        int scoreFour = PlayerPrefs.GetInt("ForestFourScore");
        int scoreFive = PlayerPrefs.GetInt("ForestFiveScore");

        int scoreOneTwo = PlayerPrefs.GetInt("CaveOneScore");
        int scoreTwoTwo = PlayerPrefs.GetInt("CaveTwoScore");
        int scoreThreeTwo = PlayerPrefs.GetInt("CaveThreeScore");
        int scoreFourTwo = PlayerPrefs.GetInt("CaveFourScore");
        int scoreFiveTwo = PlayerPrefs.GetInt("CaveFiveScore");

        int scoreOneThree = PlayerPrefs.GetInt("DungeonOneScore");
        int scoreTwoThree = PlayerPrefs.GetInt("DungeonTwoScore");
        int scoreThreeThree = PlayerPrefs.GetInt("DungeonThreeScore");
        int scoreFourThree = PlayerPrefs.GetInt("DungeonFourScore");
        int scoreFiveThree = PlayerPrefs.GetInt("DungeonFiveScore");

        int scoreOneFour = PlayerPrefs.GetInt("MountainOneScore");
        int scoreTwoFour = PlayerPrefs.GetInt("MountainTwoScore");
        int scoreThreeFour = PlayerPrefs.GetInt("MountainThreeScore");
        int scoreFourFour = PlayerPrefs.GetInt("MountainFourScore");
        int scoreFiveFour = PlayerPrefs.GetInt("MountainFiveScore");

        int sumOne = scoreOne + scoreTwo + scoreThree + scoreFour + scoreFive;
        int sumTwo = scoreOneTwo + scoreTwoTwo + scoreThreeTwo + scoreFourTwo + scoreFiveTwo;
        int sumThree = scoreOneThree + scoreTwoThree + scoreThreeThree + scoreFourThree + scoreFiveThree;
        int sumFour = scoreOneFour + scoreTwoFour + scoreThreeFour + scoreFourFour + scoreFiveFour;

        forestStarsTotal.text = sumOne + "/12 to unlock next chapter";
        caveStarsTotal.text = sumTwo + "/12 to unlock next chapter";
        dungeonStarsTotal.text = sumThree + "/12 to unlock next chapter";
        mountainStarsTotal.text = sumFour + "/12";
    }

    public void CaveUnlock()
    {
        int scoreOne = PlayerPrefs.GetInt("ForestOneScore");
        int scoreTwo = PlayerPrefs.GetInt("ForestTwoScore");
        int scoreThree = PlayerPrefs.GetInt("ForestThreeScore");
        int scoreFour = PlayerPrefs.GetInt("ForestFourScore");

        int sum = scoreOne + scoreTwo + scoreThree + scoreFour;

        if (sum >= 12)
        {
            arcTwoLock.SetActive(false);
            arcTwo.interactable = true;
        }

        else
        {
            arcTwoLock.SetActive(true);
            arcTwo.interactable = false;
        }
    }

    public void DungeonUnlock()
    {
        int scoreOne = PlayerPrefs.GetInt("CaveOneScore");
        int scoreTwo = PlayerPrefs.GetInt("CaveTwoScore");
        int scoreThree = PlayerPrefs.GetInt("CaveThreeScore");
        int scoreFour = PlayerPrefs.GetInt("CaveFourScore");

        int sum = scoreOne + scoreTwo + scoreThree + scoreFour;

        if (sum >= 12)
        {
            arcThreeLock.SetActive(false);
            arcThree.interactable = true;
        }

        else
        {
            arcThreeLock.SetActive(true);
            arcThree.interactable = false;
        }
    }

    public void MountainUnlock()
    {
        int scoreOne = PlayerPrefs.GetInt("DungeonOneScore");
        int scoreTwo = PlayerPrefs.GetInt("DungeonTwoScore");
        int scoreThree = PlayerPrefs.GetInt("DungeonThreeScore");
        int scoreFour = PlayerPrefs.GetInt("DungeonFourScore");

        int sum = scoreOne + scoreTwo + scoreThree + scoreFour;

        if (sum >= 12)
        {
            arcFourLock.SetActive(false);
            arcFour.interactable = true;
        }

        else
        {
            arcFourLock.SetActive(true);
            arcFour.interactable = false;
        }
    }

    private void Start()
    {
        DisplayForestStarScoreOne();
        DisplayForestStarScoreTwo();
        DisplayForestStarScoreThree();
        DisplayForestStarScoreFour();
        DisplayForestStarScoreFive();

        DisplayCaveStarScoreOne();
        DisplayCaveStarScoreTwo();
        DisplayCaveStarScoreThree();
        DisplayCaveStarScoreFour();
        DisplayCaveStarScoreFive();

        DisplayDungeonStarScoreOne();
        DisplayDungeonStarScoreTwo();
        DisplayDungeonStarScoreThree();
        DisplayDungeonStarScoreFour();
        DisplayDungeonStarScoreFive();

        DisplayMountainStarScoreOne();
        DisplayMountainStarScoreTwo();
        DisplayMountainStarScoreThree();
        DisplayMountainStarScoreFour();
        DisplayMountainStarScoreFive();

        CaveUnlock();
        DungeonUnlock();
        MountainUnlock();
        ShowAllStars();
    }
    public void DisplayScore()
    {

        int quizOne = PlayerPrefs.GetInt("inductiveQuizScore");
        int quizTwo = PlayerPrefs.GetInt("deductiveQuizScore");
        int quizThree = PlayerPrefs.GetInt("diagrammaticQuizScore");
        int quizFour = PlayerPrefs.GetInt("abstractQuizScore");

        Debug.Log(quizOne);
        Debug.Log(quizTwo);
        Debug.Log(quizThree);
        Debug.Log(quizFour);

        quizOneScore.SetText(quizOne.ToString() + "/10");
        quizTwoScore.SetText(quizTwo.ToString() + "/10");
        quizThreeScore.SetText(quizThree.ToString() + "/10");
        quizFourScore.SetText(quizFour.ToString() + "/10");

        float sum;

        sum = quizOne + quizTwo + quizThree + quizFour;
        Debug.Log(sum);

        float total;

        total = (sum / 40) * 100;

        quizTotal.SetText("Total: " + total.ToString() + "%");
        Debug.Log(total);
    }

    public void DisplayForestStarScoreOne()
    {

        int scoreOne = PlayerPrefs.GetInt("ForestOneScore");

        switch (scoreOne)
        {
            case 1:
                forestOneOne.SetActive(true);
                break;
            case 2:
                forestOneTwo.SetActive(true);
                break;
            case 3:
                forestOneThree.SetActive(true);
                break;
            default:
                forestOneOne.SetActive(false);
                forestOneTwo.SetActive(false);
                forestOneThree.SetActive(false);
                break;
        }
    }

    public void DisplayForestStarScoreTwo()
    {
        int scoreTwo = PlayerPrefs.GetInt("ForestTwoScore");

        switch (scoreTwo)
        {
            case 1:
                forestTwoOne.SetActive(true);
                break;
            case 2:
                forestTwoTwo.SetActive(true);
                break;
            case 3:
                forestTwoThree.SetActive(true);
                break;
            default:
                forestTwoOne.SetActive(false);
                forestTwoTwo.SetActive(false);
                forestTwoThree.SetActive(false);
                break;
        }
    }

    public void DisplayForestStarScoreThree()
    {

        int scoreThree = PlayerPrefs.GetInt("ForestThreeScore");

        switch (scoreThree)
        {
            case 1:
                forestThreeOne.SetActive(true);
                break;
            case 2:
                forestThreeTwo.SetActive(true);
                break;
            case 3:
                forestThreeThree.SetActive(true);
                break;
            default:
                forestThreeOne.SetActive(false);
                forestThreeTwo.SetActive(false);
                forestThreeThree.SetActive(false);
                break;
        }
    }

    public void DisplayForestStarScoreFour()
    {

        int scoreFour = PlayerPrefs.GetInt("ForestFourScore");

        switch (scoreFour)
        {
            case 1:
                forestFourOne.SetActive(true);
                break;
            case 2:
                forestFourTwo.SetActive(true);
                break;
            case 3:
                forestFourThree.SetActive(true);
                break;
            default:
                forestFourOne.SetActive(false);
                forestFourTwo.SetActive(false);
                forestFourThree.SetActive(false);
                break;
        }
    }

    public void DisplayForestStarScoreFive()
    {

        int scoreFive = PlayerPrefs.GetInt("ForestFiveScore");

        switch (scoreFive)
        {
            case 1:
                forestFiveOne.SetActive(true);
                break;
            case 2:
                forestFiveTwo.SetActive(true);
                break;
            case 3:
                forestFiveThree.SetActive(true);
                break;
            default:
                forestFiveOne.SetActive(false);
                forestFiveTwo.SetActive(false);
                forestFiveThree.SetActive(false);
                break;
        }
    }

    // ======================

    public void DisplayCaveStarScoreOne()
    {

        int scoreOne = PlayerPrefs.GetInt("CaveOneScore");

        switch (scoreOne)
        {
            case 1:
                caveOneOne.SetActive(true);
                break;
            case 2:
                caveOneTwo.SetActive(true);
                break;
            case 3:
                caveOneThree.SetActive(true);
                break;
            default:
                caveOneOne.SetActive(false);
                caveOneTwo.SetActive(false);
                caveOneThree.SetActive(false);
                break;
        }
    }

    public void DisplayCaveStarScoreTwo()
    {
        int scoreTwo = PlayerPrefs.GetInt("CaveTwoScore");

        switch (scoreTwo)
        {
            case 1:
                caveTwoOne.SetActive(true);
                break;
            case 2:
                caveTwoTwo.SetActive(true);
                break;
            case 3:
                caveTwoThree.SetActive(true);
                break;
            default:
                caveTwoOne.SetActive(false);
                caveTwoTwo.SetActive(false);
                caveTwoThree.SetActive(false);
                break;
        }
    }

    public void DisplayCaveStarScoreThree()
    {

        int scoreThree = PlayerPrefs.GetInt("CaveThreeScore");

        switch (scoreThree)
        {
            case 1:
                caveThreeOne.SetActive(true);
                break;
            case 2:
                caveThreeTwo.SetActive(true);
                break;
            case 3:
                caveThreeThree.SetActive(true);
                break;
            default:
                caveThreeOne.SetActive(false);
                caveThreeTwo.SetActive(false);
                caveThreeThree.SetActive(false);
                break;
        }
    }

    public void DisplayCaveStarScoreFour()
    {

        int scoreFour = PlayerPrefs.GetInt("CaveFourScore");

        switch (scoreFour)
        {
            case 1:
                caveFourOne.SetActive(true);
                break;
            case 2:
                caveFourTwo.SetActive(true);
                break;
            case 3:
                caveFourThree.SetActive(true);
                break;
            default:
                caveFourOne.SetActive(false);
                caveFourTwo.SetActive(false);
                caveFourThree.SetActive(false);
                break;
        }
    }

    public void DisplayCaveStarScoreFive()
    {

        int scoreFive = PlayerPrefs.GetInt("CaveFiveScore");

        switch (scoreFive)
        {
            case 1:
                caveFiveOne.SetActive(true);
                break;
            case 2:
                caveFiveTwo.SetActive(true);
                break;
            case 3:
                caveFiveThree.SetActive(true);
                break;
            default:
                caveFiveOne.SetActive(false);
                caveFiveTwo.SetActive(false);
                caveFiveThree.SetActive(false);
                break;
        }
    }

    // ======================

    public void DisplayDungeonStarScoreOne()
    {

        int scoreOne = PlayerPrefs.GetInt("DungeonOneScore");

        switch (scoreOne)
        {
            case 1:
                dungeonOneOne.SetActive(true);
                break;
            case 2:
                dungeonOneTwo.SetActive(true);
                break;
            case 3:
                dungeonOneThree.SetActive(true);
                break;
            default:
                dungeonOneOne.SetActive(false);
                dungeonOneTwo.SetActive(false);
                dungeonOneThree.SetActive(false);
                break;
        }
    }

    public void DisplayDungeonStarScoreTwo()
    {
        int scoreTwo = PlayerPrefs.GetInt("DungeonTwoScore");

        switch (scoreTwo)
        {
            case 1:
                dungeonTwoOne.SetActive(true);
                break;
            case 2:
                dungeonTwoTwo.SetActive(true);
                break;
            case 3:
                dungeonTwoThree.SetActive(true);
                break;
            default:
                dungeonTwoOne.SetActive(false);
                dungeonTwoTwo.SetActive(false);
                dungeonTwoThree.SetActive(false);
                break;
        }
    }

    public void DisplayDungeonStarScoreThree()
    {

        int scoreThree = PlayerPrefs.GetInt("DungeonThreeScore");

        switch (scoreThree)
        {
            case 1:
                dungeonThreeOne.SetActive(true);
                break;
            case 2:
                dungeonThreeTwo.SetActive(true);
                break;
            case 3:
                dungeonThreeThree.SetActive(true);
                break;
            default:
                dungeonThreeOne.SetActive(false);
                dungeonThreeTwo.SetActive(false);
                dungeonThreeThree.SetActive(false);
                break;
        }
    }

    public void DisplayDungeonStarScoreFour()
    {

        int scoreFour = PlayerPrefs.GetInt("DungeonFourScore");

        switch (scoreFour)
        {
            case 1:
                dungeonFourOne.SetActive(true);
                break;
            case 2:
                dungeonFourTwo.SetActive(true);
                break;
            case 3:
                dungeonFourThree.SetActive(true);
                break;
            default:
                dungeonFourOne.SetActive(false);
                dungeonFourTwo.SetActive(false);
                dungeonFourThree.SetActive(false);
                break;
        }
    }

    public void DisplayDungeonStarScoreFive()
    {

        int scoreFive = PlayerPrefs.GetInt("DungeonFiveScore");

        switch (scoreFive)
        {
            case 1:
                dungeonFiveOne.SetActive(true);
                break;
            case 2:
                dungeonFiveTwo.SetActive(true);
                break;
            case 3:
                dungeonFiveThree.SetActive(true);
                break;
            default:
                dungeonFiveOne.SetActive(false);
                dungeonFiveTwo.SetActive(false);
                dungeonFiveThree.SetActive(false);
                break;
        }
    }

    // ======================

    public void DisplayMountainStarScoreOne()
    {

        int scoreOne = PlayerPrefs.GetInt("MountainOneScore");

        switch (scoreOne)
        {
            case 1:
                mountainOneOne.SetActive(true);
                break;
            case 2:
                mountainOneTwo.SetActive(true);
                break;
            case 3:
                mountainOneThree.SetActive(true);
                break;
            default:
                mountainOneOne.SetActive(false);
                mountainOneTwo.SetActive(false);
                mountainOneThree.SetActive(false);
                break;
        }
    }

    public void DisplayMountainStarScoreTwo()
    {
        int scoreTwo = PlayerPrefs.GetInt("MountainTwoScore");

        switch (scoreTwo)
        {
            case 1:
                mountainTwoOne.SetActive(true);
                break;
            case 2:
                mountainTwoTwo.SetActive(true);
                break;
            case 3:
                mountainTwoThree.SetActive(true);
                break;
            default:
                mountainTwoOne.SetActive(false);
                mountainTwoTwo.SetActive(false);
                mountainTwoThree.SetActive(false);
                break;
        }
    }

    public void DisplayMountainStarScoreThree()
    {

        int scoreThree = PlayerPrefs.GetInt("MountainThreeScore");

        switch (scoreThree)
        {
            case 1:
                mountainThreeOne.SetActive(true);
                break;
            case 2:
                mountainThreeTwo.SetActive(true);
                break;
            case 3:
                mountainThreeThree.SetActive(true);
                break;
            default:
                mountainThreeOne.SetActive(false);
                mountainThreeTwo.SetActive(false);
                mountainThreeThree.SetActive(false);
                break;
        }
    }

    public void DisplayMountainStarScoreFour()
    {

        int scoreFour = PlayerPrefs.GetInt("MountainFourScore");

        switch (scoreFour)
        {
            case 1:
                mountainFourOne.SetActive(true);
                break;
            case 2:
                mountainFourTwo.SetActive(true);
                break;
            case 3:
                mountainFourThree.SetActive(true);
                break;
            default:
                mountainFourOne.SetActive(false);
                mountainFourTwo.SetActive(false);
                mountainFourThree.SetActive(false);
                break;
        }
    }

    public void DisplayMountainStarScoreFive()
    {

        int scoreFive = PlayerPrefs.GetInt("MountainFiveScore");

        switch (scoreFive)
        {
            case 1:
                mountainFiveOne.SetActive(true);
                break;
            case 2:
                mountainFiveTwo.SetActive(true);
                break;
            case 3:
                mountainFiveThree.SetActive(true);
                break;
            default:
                mountainFiveOne.SetActive(false);
                mountainFiveTwo.SetActive(false);
                mountainFiveThree.SetActive(false);
                break;
        }
    }
}
