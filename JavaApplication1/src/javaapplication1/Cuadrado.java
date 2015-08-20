package javaapplication1;

// la palabra super significa que estoy usando la clase superior
public class Cuadrado extends Figura {
    
    @Override
    
    public float calculaArea() 
    {
        return super.lado * super.lado;
    }
    
}
