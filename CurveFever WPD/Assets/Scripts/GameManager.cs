using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //skrypt odpoiedzialny za grę

    bool hasEnded = false;

    public void TheEndgame()
    {
        if (hasEnded)
        {
            return;
        }

        // dodać txxtboxy!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        Debug.Log("ZDECHŁEŚ");
        hasEnded = true;
        StartCoroutine(PlayEndgame());
    }

    IEnumerator PlayEndgame()
    {
        Debug.Log("KONIEC GRY");

        //po sekundzie zrestartuj gre
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
