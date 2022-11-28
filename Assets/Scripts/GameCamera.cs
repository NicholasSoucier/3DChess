using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    public Transform target;
    public float speed = 1;
    public Transform whiteTurnCamPosition;
    public Transform blackTurnCamPosition;
    private Quaternion whiteOrientation = Quaternion.Euler(0, 270, 0);
    private Quaternion blackOrientation = Quaternion.Euler(0, 90, 0);


    private void Update()
    {
        if (target) {

            this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position, speed * Time.deltaTime);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, target.transform.rotation, speed * Time.deltaTime);
        }
    }

    public void SetPosition(Transform to_point) {

        StartCoroutine(UpdateTargetAfterTime(to_point));
    }

    /*public void SetTurn(bool isWhite)
    {
        if (isWhite)
        {
            SetPosition();
        }
    }*/

    IEnumerator UpdateTargetAfterTime(Transform to_point) {

        yield return new WaitForSeconds(0.5f);

        target = to_point;

    }
}
