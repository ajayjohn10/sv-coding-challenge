  
     
    $(document).ready(function () {

    	
function showDivs(div1)
{
   d0 = document.getElementById(div1);
   

   d0.style.display = "block";
}


  $("#filteradder").click(function(){
    showDivs('addFilters');
});

   $("#find-car").click(function(){
    showDivs('results');
});

});
