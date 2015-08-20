package javaapplication1;


public class Triangulo extends Figura {
    
    private float altura ;
    
    @Override 
   
   public float calculaArea()
   {
   return(super.lado * altura)/ 2 ;
   }

    public float getAltura() {
        return altura;
    }

    public void setAltura(float altura) {
        if(altura>0)
        this.altura = altura;
    }
    
    
}
