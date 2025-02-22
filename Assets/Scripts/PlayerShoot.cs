using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject PreFab;
    public GameObject SpawnFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canshoot = true;
    private void Update()
    {
        TimerMethod();
        Shoot();




       
    }
    private void TimerMethod()
    {
        if (!_canshoot)
        {
            _currentTime -= Time.deltaTime;

            if (_currentTime > 0)
            {
                _canshoot = true;
                _currentTime = Timer;
            }
        }
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canshoot)
        {
            GameObject bullet = Instantiate(PreFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canshoot = false;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canshoot)
        {
            GameObject bullet = Instantiate(SpawnFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canshoot = false;
        }

    }






}

    
    
        
    




