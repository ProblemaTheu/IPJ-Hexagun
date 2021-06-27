using UnityEngine;

public class HexMap : MonoBehaviour
{
    System.Random rNd = new System.Random();

    public GameObject Plano;
    public GameObject Montanha;
    public GameObject Agua;
    public GameObject Buraco;
    public GameObject Plano1;
    public GameObject Montanha1;
    public GameObject Agua1;
    public GameObject Buraco1;
    public GameObject Plano2;
    public GameObject Montanha2;
    public GameObject Agua2;
    public GameObject Buraco2;

    [SerializeField]int larMapa = 5;
    [SerializeField]int altMapa = 7;


    public float tileXOffset = 1.8f;
    public float tileZOffset = 1.565f;

    void Start(){

        CriarMapa();
    }

    void CriarMapa(){

        int rd = rNd.Next(1,31);

        if(1<=rd && rd<=10){

            for(int x=0; x <= larMapa; x++){
            for(int z=0; z <=altMapa; z++){

                int r = rNd.Next(1,101);

                if(r<=70){
                    GameObject TempGO = Instantiate(Plano);

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }
                }
                else if(70<r && r<=85){
                    GameObject TempGO = Instantiate(Montanha);



                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(85<r && r<=90){
                    GameObject TempGO = Instantiate(Agua);   

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(90<r && r<=100){
                    GameObject TempGO = Instantiate(Buraco);    

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }                
                }
            }
        }
    }

    if(10<rd && rd<=20){

            for(int x=0; x <= larMapa; x++){
            for(int z=0; z <=altMapa; z++){

                int r = rNd.Next(1,101);

                if(r<=70){
                    GameObject TempGO = Instantiate(Plano1);

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }
                }
                else if(70<r && r<=85){
                    GameObject TempGO = Instantiate(Montanha1);



                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(85<r && r<=90){
                    GameObject TempGO = Instantiate(Agua1);   

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(90<r && r<=100){
                    GameObject TempGO = Instantiate(Buraco1);    

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }                
                }
            }
        }
    }

    if(20<rd && rd<=30){

        for(int x=0; x <= larMapa; x++){
            for(int z=0; z <=altMapa; z++){

                int r = rNd.Next(1,101);

                if(r<=70){
                    GameObject TempGO = Instantiate(Plano2);

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }
                }
                else if(70<r && r<=85){
                    GameObject TempGO = Instantiate(Montanha2);



                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(85<r && r<=90){
                    GameObject TempGO = Instantiate(Agua2);   

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(90<r && r<=100){
                    GameObject TempGO = Instantiate(Buraco2);    

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }                
                }
            }
        }
    }

    int rd2 = rNd.Next(1,31);

    if(1<=rd2 && rd2<=10){

        for(int x=larMapa; x >= 0; x=x-1){
            for(int z=-1*(altMapa+1); z <= (-1*(altMapa+1))+altMapa; z++){

                int r = rNd.Next(1,101);

                if(30<r && r<=100){
                    GameObject TempGO = Instantiate(Plano);

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }
                }
                else if(15<r && r<=30){
                    GameObject TempGO = Instantiate(Montanha);



                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(5<r && r<=15){
                    GameObject TempGO = Instantiate(Agua);   

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(r<=5){
                    GameObject TempGO = Instantiate(Buraco);    

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }                
                }
                
            }
        }
    }

    if(10<rd2 && rd2<=20){
        
        for(int x=larMapa; x >= 0; x=x-1){
            for(int z=-1*(altMapa+1); z <= (-1*(altMapa+1))+altMapa; z++){

                int r = rNd.Next(1,101);

                if(30<r && r<=100){
                    GameObject TempGO = Instantiate(Plano1);

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }
                }
                else if(15<r && r<=30){
                    GameObject TempGO = Instantiate(Montanha1);



                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(5<r && r<=15){
                    GameObject TempGO = Instantiate(Agua1);   

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(r<=5){
                    GameObject TempGO = Instantiate(Buraco1);    

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }                
                }
                
            }
        }
    }

    if(20<rd2 && rd2<=30){
        
        for(int x=larMapa; x >= 0; x=x-1){
            for(int z=-1*(altMapa+1); z <= (-1*(altMapa+1))+altMapa; z++){

                int r = rNd.Next(1,101);

                if(30<r && r<=100){
                    GameObject TempGO = Instantiate(Plano2);

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }
                }
                else if(15<r && r<=30){
                    GameObject TempGO = Instantiate(Montanha2);



                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(5<r && r<=15){
                    GameObject TempGO = Instantiate(Agua2);   

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                }               
                }
                else if(r<=5){
                    GameObject TempGO = Instantiate(Buraco2);    

                    if(z%2 == 0){

                    TempGO.transform.position = new Vector3(x *tileXOffset, 0.05f, z *tileZOffset);


                }
                else{

                    TempGO.transform.position = new Vector3(x * tileXOffset + tileXOffset/2, 0.05f, z * tileZOffset);
                        }                
                    }    
                }
            }
        }
    }
}
        


      
