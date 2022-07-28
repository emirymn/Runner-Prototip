using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalSystem : MonoBehaviour
{
    [SerializeField] ParticleSystem itemPortalPartical;
    [SerializeField] ParticleSystem itemFeedPartical;
    [SerializeField] ParticleSystem itemDeadPartical;
    [SerializeField] ParticleSystem itemNosPartical;

    private void OnEnable()
    {
        StaticEvents.InLevelPortal += PlayPortalPartical;
        StaticEvents.TakeLwUPCollectables += PlayFeedPartical;
        StaticEvents.HitObstable += PlayDeadPartical;
        StaticEvents.OnTakeNos += PlayNosPartical;
    }
    private void OnDisable()
    {
        StaticEvents.InLevelPortal -= PlayPortalPartical;
        StaticEvents.TakeLwUPCollectables -= PlayFeedPartical;
        StaticEvents.HitObstable -= PlayDeadPartical;
        StaticEvents.OnTakeNos -= PlayNosPartical;
    }
    private void PlayPortalPartical(int value)
    {
       // if (itemPortalPartical == null) return;
        itemPortalPartical.Play();
    }
    private void PlayFeedPartical()
    {
        if (itemFeedPartical == null) return;
        itemFeedPartical.Play();
    }
    private void PlayDeadPartical()
    {
        if (itemDeadPartical == null) return;
        itemDeadPartical.Play();
    }
    private void PlayNosPartical()
    {
        if (itemNosPartical == null) return;
        itemNosPartical.Play();
    }
}
