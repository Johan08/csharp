package javaapplication1;

public class Figura {
    
    protected float lado ;
    
    public float calculaArea()
    {
        return 0f ;
    }

    public float getLado() {
        return lado;
    }

    public void setLado(float lado) {
       if (lado > 0)
        this.lado = lado;
    }
    
    
    
}
