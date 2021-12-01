// Make sure the webpage has finished loading
$(function() {
    
    // Declare variables
    var i = 0, // Incrementor
    $form = $('#form'), // The form on our webpage
    $submitButton = $('#form > #submit'), // The form submit button
    $gameButton = $('#game'), // The game button
    
    // Calculate a random left displacement for $button
    getRandomLeft = function() {
        return Math.random() * 500;
    },
    
    // Calculate a random top displacement for $button
    getRandomTop = function() {
        return Math.random() * 500;
    };
    
    // Hide the form submit button
    $submitButton.hide(1);
    
    // Add a click event to the Game Button
    $gameButton.click(function() {
        
        // Increment i by 1
        i++
        
        if (i == 19) { // After the game button has been clicked 19 times
            
            // Hide the game button
            $gameButton.hide(1);
            
            // and Show the form submit button
            $submitButton.show(1);
        
        }
        else { // before the game button has been clicked 19 times
        
          // randomly change the its positioning
          $gameButton.css({
          
            left: getRandomLeft,
            top: getRandomTop
          
          });  
        };
    });
});