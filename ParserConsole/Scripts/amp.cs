main()
{
    decimal Vcc = 12.0;
    decimal Vin = 0.1;
    int Av = 10;

    decimal Re = 1000;
    decimal Rc = 10000;
    decimal Vceq = Vcc / 2;
    decimal Icq = (Vcc * 0.5) / (Rc + Re);
    decimal Vrc = Icq * Rc;
    decimal Vc = Vcc - Vrc;
    decimal Ib = Icq / 150;
    decimal Ie = Icq + Ib;
    decimal Ve = Ie * Re;
    decimal Vb = 0.7 + Ve;
    decimal IR2 = 10 * Ib;
    decimal R2 = Vb / IR2;
    decimal IR1 = 11 * Ib;
    decimal VRI1 = Vcc - Vb;
    decimal R1 = VRI1 / IR1;

    string cIcq = Current(Icq);
    string cIe = Current(Ie);
    string cIb = Current(Ib);
    string cIR1 = Current(IR1);
    string cIR2 = Current(IR2);

    printf("Icq = ", cIcq);
    printf("Vrc = ", Vrc.ToString());
    printf("Vc = ", Vc.ToString());
    printf("Ib = ", cIb);
    printf("Ie = ", cIe);
    printf("Ve = ", Ve.ToString());
    printf("Vb = ", Vb.ToString());
    printf("IR2 = ", cIR2);
    printf("R2 = ", R2.ToString());
    printf("IR1 = ", cIR1);
    printf("VRI1 = ", VRI1.ToString());
    printf("R1 = ", R1.ToString());
}