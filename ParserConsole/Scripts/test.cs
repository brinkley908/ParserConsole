﻿
import "e:\\Dev\\ParserConsole\\ParserConsole\\Scripts\\funcs.cs";


json js = { "contacts" : [{"name" : "john"}, {"name" : "jane"}]};
int i, j;
string s = "hasta lavista";
decimal d = 0.5;

main()
{
    datetime n = Now();
    printf(n);
    printf("mult: ", sum(15, 5));

    testfunc();

    json js2 = { "name": { "first": "richard", "last":"brinkley" } };

    printf("hello ", js2->name->last, ", contacts:", js->contacts);
    printf(s);

    int i = 5, j = 100;

    i = 10;

    j = i * 2;
    i = j / 2;
    ++i;
    printf("++i =", i);

    ++i;
    printf("++i =", i);

    i++;
    printf("i++ =", i);

    j = 10;
    printf("eval ", j + (4 * 5) - 3);

    for (i = 0; i < 20; i++)
    {
        j = i * 2;
        printf(i, ") j = ", j);

        if (i <= 5)
        {
            printf("i <= 5");
        }
        else
        {
            printf("i > 5");
        }
    }

    i = 10;
    while (i > 0)
    {
        printf("While i = ", i);
        --i;
    }

    do
    {

        printf("Do i = ", i);
        ++i;
    } while (i < 15)

    i = 9;
    j = 0;

    int x = 6;

    if (i == 9 && j == 0 && x==6)
    {
        printf("AND");
    }

    if (i == 9 || j == 0)
    {
        printf("OR");
    }

printf("div ", div(10, 2));
}

testfunc()
{
    printf("TEST FUNC");
}

mult(int num)
{
    return (num * 2);
}