
main()
{
    decimal Vin = 0.1;
    decimal Vcc = 13.8;
    int beta = 300;
    decimal Ic = Vcc / 10;
    decimal Icq = 10mA;

    decimal Re = Ic / Icq;

    decimal base = Ic + 0.7;
    decimal Ib = Icq / beta;

    decimal R2 = base / (10 * Ib);

    decimal R1 = (Vcc - base) / (11 * Ib);

    decimal Rc = ((Vcc - Ic) / 2) / Icq;

    decimal p = PI();

    decimal x = Vcc * p;

    printf(base);
    printf("Ib = ", Current(Ib));
    printf("Ic = ", Ic);
    printf("Rc = ", Rc);
    printf("Re = ", Re);
    printf("R1 = ", R1);
    printf("R2 = " + R2.ToString());
}

Ohms(decimal v, decimal c)
{
    decimal x = v / c;
    return x;
}
Add(decimal a, decimal b){
    return a/b;
}