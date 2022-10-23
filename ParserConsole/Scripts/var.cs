main()
{
    var d = true;
    int x = -1;

    datetime dat1 = Date(2019, 05, 09, 14, 30, 12);
    datetime dat2 = Now();

    printf("Date 1=", dat1);
    printf("Date 2=", dat2);

    var diff = DateDiff(dat1, dat2, 3).Seconds();
    printf("Diff ", DateDiff(dat1, dat2, 3).TotalSeconds());

    json i = { "contacts": [{ "name": "john" }, { "name": "jane" }]};



}