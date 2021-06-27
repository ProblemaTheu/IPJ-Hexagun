/*using UnityEngine;

public class HexMap1 : MonoBehaviour
{
    System.Random rNd = new System.Random();

    public GameObject Plano;
    public GameObject Montanha;
    public GameObject Agua;
    public GameObject Buraco;

    [SerializeField]int larMapa = 5;
    [SerializeField]int altMapa = 7;

    public float tileXOffset = 1.8f;
    public float tileZOffset = 1.565f;

    void Start()
    {
        CriarMapa();
        
    }

    
    void CriarMapa()
    {
        for(int x=0; x <= larMapa; x++){
            for(int z=-1*(altMapa+1); z <= (-1*(altMapa+1))+altMapa; z++){

                int r = rNd.Next(1,101);

                if(30<r && r<=100){
                    GameObject TempGO = Instantiate(Plano);

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0, z * tileZOffset);
                }
                }
                else if(15<r && r<=30){
                    GameObject TempGO = Instantiate(Montanha);



                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0, z * tileZOffset);
                }               
                }
                else if(5<r && r<=15){
                    GameObject TempGO = Instantiate(Agua);   

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0, z * tileZOffset);
                }               
                }
                else if(r<=5){
                    GameObject TempGO = Instantiate(Buraco);    

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0, z * tileZOffset);
                }                
                }
                
            }
        }
    }
}
*/