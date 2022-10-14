using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    #region Champ
    [SerializeField] PlayerTag _target;
    [SerializeField, Layer] string _mapLayer;

    public PlayerTag Target { get { return _target; } }
    #endregion

    #region OnTriggerEnter
    private void OnTriggerEnter (Collider other)//évenement qui se passe lorsque quelqu'un entre dans la zone de trigger.
    {
        EnemyMovement (other);
    }
    #endregion

    #region OnTriggerStay
    private void OnTriggerStay (Collider other)//évenement qui se passe lorsqu'on veux vérifier si quelqu'un est toujours dans la zone de trigger.
    {
        EnemyMovement (other);
    }
    #endregion


    #region EnemyMovement(méthode commune aux Trigger)
    void EnemyMovement (Collider other)
    {
      if(other.TryGetComponent<PlayerTag>(out PlayerTag Target))//ici target est une variable qui va se crée en cas de contact avec un PlayerTag, elle n'a rien à voir avec _target dans le champ.
        {
            var origin = transform.position;
            var direction = Target.transform.position - transform.position;
            if (Physics.Raycast (origin, direction, direction.magnitude, LayerMask.GetMask (_mapLayer)))
            {
                Debug.DrawLine (origin, origin + direction, Color.red, 1f);
            }
            else
            {
                Debug.DrawLine (origin, origin + direction, Color.green, 1f);
                _target = Target;
            }
        }
    }
    #endregion

    #region OnTriggerExit
    private void OnTriggerExit (Collider other)//évenement qui se passe lorsque quelqu'un sort de la zone de trigger.
    {
        if (other.TryGetComponent(out PlayerTag Target) && Target == _target)
        {
            _target = null;
        }
    }
    #endregion
}
