$(document).ready(function() {

    // Reference variables
    var $ninjaTab = $('#ninjaTab'),
        $ninjaJump = $('#ninjaJump'),
        $ninjaPanel = $('#ninjaPanel'),
        $ninjaWarrior = $('#ninjaWarrior'),
        $webNinjaLink = $('a#webNinjaLink'),
        $webWarrior = $('#webWarrior');
    
    // Rotate img#ninjaJump 30 degrees
    $ninjaJump.rotate(30);
        
    // Set up a hover event on div#ninjaTab
    $ninjaTab.hover(function() { // mouseover
    
        // Save a reference to the current element
        $self = $(this);
        
        // Add .activeNinja to the element being moused over
        $self.attr('class','activeNinja');
        
        /* animate() img#ninjaJump (after stopping any animation 
        on it that is currently running). */
        $ninjaJump.stop(true, true).animate({
        
            left: 5,
            opacity: 1
        
        }, 100).rotate(-30, 200);
    
    }, function() { // mouseout
    
        // Reverse what was done in the mouseover
        $ninjaJump.stop(true, true).css({
        
            left: -30,
            
        }).animate({
        
            opacity: 0.4
        
        }, 100).rotate(30, 200);
    
    // Set up a click event on div#ninjaTab
    }).click(function() {
        
        // Open or Close #ninjaPanel and set up a hover event on it
        $ninjaPanel.toggle(200).hover(function() { // mouseover
            
            // Make the ninja switch direction (by changing the ninja image)
            $ninjaWarrior.attr('src', 'images/ninja02_small2.png').stop(true,true).fadeTo('slow', 0.7);
        
        }, function() { // mouseout
        
            $ninjaWarrior.attr('src', 'images/ninja02_small.png').stop(true,true).fadeTo('slow', 0.3);
        
        }); // End $ninjaPanel.toggle and .hover
        
        // Set up a hover event on #webNinjaLink
        $webNinjaLink.hover(function() {
        
            $ninjaWarrior.animate({
            
                top: 240,
                left: 40
            
            }, 300, 'easeOutQuad', function(){
            
                TweenLite.to($webWarrior, 1, {
					css:{
            
						top: 260,
						left: 120,
						opacity: 1
            
					}
				});
            
            }); // End $ninjaWarrior.animate
        
        }); // End $webNinjaLink.hover
    
    }); // End $ninjaTab.hover and .click
    
    
    
}); // End .ready