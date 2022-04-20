using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//����ʹ��unity��ui������ϵͳ�������ռ�
//using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

    //Ϊ������������������ٶȺ��ı�ui
   
    public TextMeshProUGUI countText;
    public GameObject winTextobject;
    private int count;

    
    void Start()
    {


        count = 0;
        SetCountText();
        winTextobject.SetActive(false);

       

    }


   


    private void OnTriggerEnter(Collider other)
    {
        //��������ཻ����Ϸ�������coingold�����ǩ
        if (other.gameObject.CompareTag("CoinGold")) ;
        {
            other.gameObject.SetActive(false);

            count = count + 1;

            SetCountText();

        }
    }
    
    private void SetCountText()
    {
        countText.text = "count:" + count.ToString();

        if (count >= 12)
        {
            winTextobject.SetActive(true);
        }
    }

    public void Quit()
    {
        
    }
}
