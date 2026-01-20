using UnityEngine;

public class Pistol : Gun
{
    public override void Shoot()
    {
        Debug.Log("Shooting");
        if (timer.IsFinished())
        {
            //Reset Timer
            timer.StartTimer(time_between_shots);

            //Do the raycast and store the info from it in hit
            RaycastHit hit;
            if (Physics.Raycast(transform.parent.position, transform.parent.forward * range, out hit))
            {
                GameObject new_marker = Instantiate(hit_marker, hit.point, Quaternion.identity);
            }
        }
    }
}
