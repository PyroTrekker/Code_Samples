// only run this code when the page content is done loading
$(document).ready(function() {
// shortcut for above line
// $(function() {          });

	var $menu = $('#subMenu > ul'),
	    $menuItems = $menu.children('li'),
		$imgWrapper = $menuItems.children('a'),
		$menuItemsPreview = $imgWrapper.children('.menuPreview'),
		totalItems = $menuItems.length,
		
		// shortcut JS syntax for creating the equivalent of 
		// a class called ExpandingMenu
		ExpandingMenu = (function() {
		
			// @currentIndex property is the index of the currently active 
			// li image slice
			var currentIndex = -1;
			//var currentIndex = 0,
			
			// @anim property
			// Will be set to true if we want to animate the default
			// opened item
			anim = true,
			
			// Check if the currentIndex is valid (between 0 and number
			// of li image slices - 1)
			validCurrent = function() {
				return (currentIndex >= 0 && currentIndex < totalItems);
			},
			
			// Define a method of ExpandingMenu named init() which will
			// be called to begin all of our effects work
			init = function() {
			
				// Show the default li image slice only if our currentIndex
				// is set to a valid index number
				if (validCurrent()) {
					configureMenu();  // slide open default li image slice's .menuDescription content
				}
				
				// Handle the user clicking on one of our li image slices
				// taking into account the current state of the li 
				// (open/closed)
				clickHandler();
			
			},
			
			
			openItem = function(sliceIndex) {
			
				// "Click" the indicated <a> tag via jQuery
				$imgWrapper.eq(sliceIndex).click();
			
			},
			
			
			clickHandler = function() {
			
				$imgWrapper.bind('click.ExpandingMenu', function(e) {
				
					var $this = $(this); // wrap our clicked object in a jQuery object
					
					// get the parent of our clicked a tag, which is an li tag
					var $parentLI = $this.parent();
					
					// get the index of this li tag relative to its siblings
					var idx = $parentLI.index();
					
					//
					// if the currentIndex is identical to idx, then the clicked <li>
					// link is already open so we will slide it closed and we will
					// reset the current index value to -1 (meaning no panels are 
					// currently open).
					// else currentIndex is not identical to idx so open the clicked <li>
					// and if any other <li> panel is currently open, close it.
					//
					if (currentIndex === idx) {
						slideOutItem($parentLI, false, 1500, 'easeOutQuint', true);
						currentIndex = -1;
					}
					else { // <li> is closed. Open it and close any others that are open.
						
						// check if any panels are currently open and close them
						if (validCurrent()) {
							slideOutItem($menuItems.eq(currentIndex), false, 250, 'jswing');
						}
						
						// reset currentIndex to reflect the panel we are about to open
						currentIndex = idx;
						
						// open the <li> that was clicked
						slideOutItem($parentLI, true, 250, 'jswing');
					}
					
					// prevent browser default action of user clicking on a link (<a> tag)
					return false;
				
				});
			
			},
			
			// slide open the default li item.  May or may not be called depending
			// whether currentIndex is valid (called) or not (not called).
			configureMenu = function() {
			
				// get the li that corresponds to our currentIndex
				var $item = $menuItems.eq(currentIndex);
				
				// Slide the current li open with animation if anim = true
				if (anim) {
					slideOutItem($item, true, 900, 'easeInQuint');
				}
				else {  // anim == false
					$item.css({width: '415px'})
						 .find('.menuImage')   // finds span.menuImage inside current li
						 .css({left: '0px',
						       opacity: 1});   // set color image to left and make fully opaque
				}
			
			},
			
			//
			// Slide open/closed an li item
			//
			// $item - a jQuery object containing matched li
			// dir - tells us if we are opening (true) or closing (false) an li
			// speed - specify the duration opening/closing takes (milliseconds)
			// easing - easing type
			// allClosed - true only when all li items are in a "closed" state
			//			   in which case we'll set opacity on al of them to 1 (fully opaque)
			//
			slideOutItem = function($item, dir, speed, easing, allClosed) {
			
				var bwParam, colorParam;
				
				// Get span.menuImage under the current passed-in li - the color image
				var $colorImage = $item.find('.menuImage');
				
				// if the dir parameter is true (open panel), then set the width
				// of the li to 415px else (dir == false) close the panel by
				// setting its width to 90px
				if (dir) { // open panel
					bwParam = {width: '415px'};
					colorParam = {lefte: '0px'};
				}
				else { // dir == false, close panel
					bwParam = {width: '90px'};
					colorParam = {left: '90px'};
				}
				
				if (dir) { // open panel
					$menuItemsPreview.stop()
									 .animate({opacity: 0.1}, 1000);
				}
				else if (allClosed) { // all li's are closed, so make them all opaque again
					$menuItemsPreview.stop()
									 .animate({opacity: 1}, 1500);
				}
				
				// The B&W image expands or collapses based on the width property stored
				// in our bwParam object above
				$item.stop()
					 .animate(bwParam, speed, easing);
					 
				// Slide the color image in/out based on the left property stored in
				// our colorParam object from above
				$colorImage.stop()
						   .animate(colorParam, speed, easing, function() {});
				
				
				// if we are opening an item(dir is true), we want to animate
				// the opacity of the color image to 100%. If we are closing
				// an item, then reset opacity to 20% with no animation
				if (dir) {
					$colorImage.animate({opacity: 1}, 2000);
				}
				else { // dir is false
					$colorImage.css('opacity', 0.2);
				}
				
			};  // end slideOutItem()
			
			//
			// Return the init method to expose it for use outside this object definition
			// (ExpandingMenu).  Note that the other methods are not exposed via the return
			// statement thus "hiding" them within the object.  This also makes the ExpandingMenu
			// prototype object (__proto__object) available for use outside the object definition.
			//
			return {
				init: init,
				openItem: openItem
			};
		
		})();  // end ExpandingMenu object (class) definition
		
		//
		// Call the init() method of ExpandingMenu object
		//
		ExpandingMenu.init();  // get the ball rolling...
		
		ExpandingMenu.openItem(3); // open an <li> panel by default

});