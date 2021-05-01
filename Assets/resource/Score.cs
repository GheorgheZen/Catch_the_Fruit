using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private int _score = 0;
    [SerializeField]
    public Text _TxT;
    [SerializeField]
    private GameObject _particle;

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 pos = collision.gameObject.transform.position;
        int count = collision.gameObject.GetComponent<Fruits_Vegetables>().score;
        _score += count;
        _particle.GetComponent<TextMesh>().text = count.ToString();
        Instantiate(_particle, new Vector3(pos.x, 0.10f, pos.z), transform.rotation);
        DestroyObject(collision.gameObject);
        _TxT.text = _score.ToString();
    }
}
