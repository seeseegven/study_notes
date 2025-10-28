# include <stdio.h>`

int main()
{
    int blank, digit, i, other; 
    char ch;
   
    blank = digit = other = 0; 
    for (i = 1; i <= 15; i++){ 
        ch = getchar();  
        switch (ch) {
            case ' ':
            case '\n': 
                blank++;
                break;
            case '0': case '1': case '2': case '3': case '4':
            case '5': case '6': case '7': case '8': case '9':
            digit++;
            break;
            default:
                other++;
                break;

        }     
    }
    printf("blank = %d, digit = %d, other = %d\n", blank, digit, other);

    return 0;
}