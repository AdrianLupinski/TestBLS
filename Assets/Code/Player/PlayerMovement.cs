using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Value Of Ship Speed")][SerializeField] float sensitivity = 1f;
    [Tooltip("Range Of Ship Movment On Y")][SerializeField] float rangey = 10f;

    private float yThrow;
    void Update()
    {
        ProcessTranslation();
    }
    void ProcessTranslation()
    {
        yThrow = Input.GetAxis("Vertical");

        float offSetY = (yThrow * Time.deltaTime) * sensitivity;
        float rawYPossition = transform.localPosition.y + offSetY;
        float ClampYPossition = Mathf.Clamp(rawYPossition, -rangey, rangey);
        transform.localPosition = new Vector3(transform.position.x, ClampYPossition, transform.localPosition.z);
    }
}