main()
{

    decimal pp = PI();
    decimal Vcc = 9;
    decimal OI = 10000;
    decimal Gain = 10;
    decimal Bandwidth = 20;
    decimal DiodeDrop = 0.65;
    int Beta = 100;

    decimal RC = OI;
    decimal RE = RC / Gain;
   
    decimal Icsat = Vcc / (RC + RE);
    decimal Iq = Icsat / 2;
    decimal Vceq = Vcc - (Iq * (RC + RE));
    decimal Ve = Iq * RE;
    decimal Vb = Ve + DiodeDrop;
    decimal Ib = Iq / Beta;
    decimal R2 = (Beta * RE) / 10;
    decimal IR2 = 10 * Ib;
    decimal R1 = Vcc * (R2 / Vb) - R2;

    decimal C1 = Cap1(R1, R2, 20);

    decimal C2 = Cap2(RC, 100, 20);

    printf("PI = ", pp);
    printf("RC = ", Ohms(RC));
    printf("RE = ", Ohms(RE));
    printf("Ic(sat) = ", Current(Icsat));
    printf("Iq = ", Current(Iq));
    printf("Ib = ", Current(Ib));
    printf("Vceq = ", Volts(Vceq));
    printf("Ve = ", Volts(Ve));
    printf("Vb = ", Volts(Vb), Round(Vb, 2));
    printf("Diode Drop = ", Volts(DiodeDrop));
    printf("R2 = ", Ohms(R2));
    printf("IR2 = ", Current(IR2));
    printf("R1 = ", Ohms(R1));

    printf("Rx = ", Ohms(200));
    printf("Rx2 = ", Ohms(220.6));
    printf("Rm = ", Ohms(2327466.6));

    printf("C1 = ", Farads(C1));
    printf("C2 = ", Farads(C2));

    
}


Cap1(decimal r1, decimal r2, decimal f)
{
    decimal p2 = PI() * 2;

    decimal para = (r1 * r2) / (r1 + r2);

    decimal cap = 1 / (p2 * para * f);

    return cap;
}

Cap2(decimal r1, decimal i, decimal f)
{
    decimal p2 = PI() * 2;

    decimal cap = 1 / (p2 * (r1 * i) * f);

    return cap;
}