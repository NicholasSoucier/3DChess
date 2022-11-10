using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    public Transform target;
    public float speed = 1;
    private void Update()
    {
        if (target) {

            this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position, speed * Time.deltaTime);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, target.transform.rotation, speed * Time.deltaTime);
        }
    }

    public void SetPosition(Transform _point) {

        StartCoroutine(UpdateTargetAfterTime(_point));
    }

    IEnumerator UpdateTargetAfterTime(Transform _point) {

        yield return new WaitForSeconds(0.5f);

        target = _point;

    }
}
