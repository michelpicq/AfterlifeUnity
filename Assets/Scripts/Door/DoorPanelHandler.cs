using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPanelHandler : MonoBehaviour
{
    [SerializeField] private DoorHendler _doorHandler = null;
    [SerializeField] private List<GameObject> _minigames = null;

    private void OnEnable()
    {
        EnableMiniGames();
    }

    public void EnableMiniGames()
    {
        int rand = Random.Range(0, _minigames.Count);

        for (int i = 0; i<_minigames.Count; i++)
        {
            if(i==rand)
            {
                _minigames[i].gameObject.SetActive(true);
            }
            else
            {
                _minigames[i].gameObject.SetActive(false);
            }


        }
    }

    public void DisablePanel()
    {
        gameObject.SetActive(false);
    }

    public void OnWinMiniGames()
    {
        _doorHandler.IssueCounter--;
        if(_doorHandler.IssueCounter > 0)
        {
            EnableMiniGames();
        }
        _doorHandler.DecreaseTension();

    }
}
