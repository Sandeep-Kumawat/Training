function add(num1,num2,...eq)
{
    var len=eq.length;
    //console.log(len);
    
    if(len>0)
    {
        var sum=0;
        var res=num1+num2;
        for(var i in eq)
        {
            sum +=eq[i];
        }
        return Math.abs(res-sum);

    }
    else{
        var res=num1+num2;
        if(Number.isNaN(res))
        {
            return -1;
        }
        else{
            return res;
        }
    }
}
var b=add(10,10);
console.log(b);
var a=add(1,2);
console.log(a);
var c=add(1);
console.log(c);
var d=add();
console.log(d);
var e=add(1,2,3,5,4);
console.log(e);