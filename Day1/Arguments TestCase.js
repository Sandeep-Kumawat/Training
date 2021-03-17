function Add(num1,num2)
{
    //var arg=arguments.length;
    var res = num1+num2;
    var para=arguments.length;
    //console.log(para);
        if(para<2)
        {
            return 0; 
        }
     else if(para>2){
        var diff=0;
        for(var i=2;i<para;i++)
        {
            diff +=arguments[i];
        }
        return Math.abs(res-diff);
             
     }
    else{
    
    if(Number.isNaN(res))
    {
        return -1;
    }
    else{
        return res;
    }
}


}
var a=Add(3,5);
console.log(a);
var b=Add(5,6,8,9);
console.log(b);
var c=Add(1);
console.log(c);
var d=Add();
console.log(d);
var e=Add(1,x);
console.log(e);
