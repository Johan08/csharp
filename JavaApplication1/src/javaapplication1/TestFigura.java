
package javaapplication1;


 
public class TestFigura {

 
    public static void main(String[] args) {
       
        Cuadrado objC = new Cuadrado() ;
        Triangulo objT = new Triangulo() ;
        
        
        
        
        objC.setLado(5);
        System.out.println("Area del cuadrado es: " +objC.calculaArea()) ;
        
        objT.setLado(3);
        objT.setAltura(12);
        System.out.println("Area del triangulo es: " +objT.calculaArea()) ;
        
    }
}
