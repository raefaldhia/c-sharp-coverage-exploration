using System;

namespace c_sharp_coverage_exploration
{
    public class Faktorial {
       	public static int factorial (int bilangan) {
            int hasil = 0;
            if(bilangan < 0) {
                hasil = -1;
            }else {
                hasil = 1;
                for (int i = bilangan; i > 0; i--) {
                    hasil = hasil * i;
                }
            }
            return hasil;
        }
    }
}