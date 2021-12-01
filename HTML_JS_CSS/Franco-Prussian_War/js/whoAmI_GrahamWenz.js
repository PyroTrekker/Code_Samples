// Make sure the web page has finished loading with jQuery’s ready() method
$(document).ready(function() {
    
    // Reference variables
    var $whoAmI = $('#whoAmI');
    var $whoText = $('#whoAmIText');
    var $mystery = $('#mysteryPanel');
    var $mysteryText = $($mystery.find('h3'));
        
    // Create hover event for $whoAmI
    $whoAmI.hover(function(){
    
        // On hover over (mouseover), stop any currently
        // running animation on this image and then fade
        // to full opacity - using chaining
        $(this).stop(true, true).fadeTo("slow", 1);
        
        // Do the same for $whoText
        $whoText.stop(true, true).fadeTo("slow", 1);
    
    }, function() {
        
        // On hover off (mouseout), stop any current animations
        // and fade the image to 40% opacity
        $(this).stop(true, true).fadeTo("slow", 0.4);
        
        // Do the same for $whoText
        $whoText.stop(true, true).fadeTo("slow", 0.4);
        
    }); 
    
    // Create click event for $whoAmI
    $whoAmI.click(function(){
        
        // Toggle $mystery visibility
        $mystery.stop(true, true).toggle('fast');
    
    });
    
    // Create click event for h3 located in $mystery
    $mysteryText.click(function() {
    
        // Fade out img#silhouette over 5 seconds 
        $('img#silhouette').fadeOut(5000);
        
        // Fade in img#revealed after a 3 second delay
        $('img#revealed').delay(3000).fadeIn(1000, function(){
            
            // This code will only run after the above animation has finished
            
            // Replace text of $mysteryText with "Marechal Patrice MacMahon"
            // and remove clickability from it
            // (set cursor to 'default', instead of 'pointer')
            $mysteryText.text('Marechal Patrice MacMahon').css
                ('cursor', 'default');
        
        });       
    
    });    

});