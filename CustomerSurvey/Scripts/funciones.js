$(document).ready(function(e) {
	
	if (!String.prototype.trim) {
		(function() {
			// Make sure we trim BOM and NBSP
			var rtrim = /^[\s\uFEFF\xA0]+|[\s\uFEFF\xA0]+$/g;
			String.prototype.trim = function() {
				return this.replace(rtrim, '');
			};
		})();
	}

	[].slice.call( document.querySelectorAll( 'input.input__field' ) ).forEach( function( inputEl ) {
		// in case the input is already filled..
		if( inputEl.value.trim() !== '' ) {
			classie.add( inputEl.parentNode, 'input--filled' );
		}

		// events:
		inputEl.addEventListener( 'focus', onInputFocus );
		inputEl.addEventListener( 'blur', onInputBlur );
	} );

	function onInputFocus( ev ) {
		classie.add( ev.target.parentNode, 'input--filled' );
	}

	function onInputBlur( ev ) {
		if( ev.target.value.trim() === '' ) {
			classie.remove( ev.target.parentNode, 'input--filled' );
		}
	}

	/* ICONOS RAITN */
	$('.ico_califica li').click(function(e) {
		var ob = $(this).attr('class');

		if(ob == 'ico_1'){
			$(this).find('img').attr('src', '/Content/images/1_b.png');
			$('.ico_califica li.ico_2').find('img').attr('src', '/Content/images/2_a.png');
			$('.ico_califica li.ico_3').find('img').attr('src', '/Content/images/3_a.png');
		    $('#Rating').val('Thumbs Up');
		}else if(ob == 'ico_2'){
		    $(this).find('img').attr('src', '/Content/images/2_b.png');
		    $('.ico_califica li.ico_1').find('img').attr('src', '/Content/images/1_a.png');
		    $('.ico_califica li.ico_3').find('img').attr('src', '/Content/images/3_a.png');
			$('#Rating').val('Thumbs Neutral');
		}else if(ob == 'ico_3'){
		    $(this).find('img').attr('src', '/Content/images/3_b.png');
		    $('.ico_califica li.ico_1').find('img').attr('src', '/Content/images/1_a.png');
		    $('.ico_califica li.ico_2').find('img').attr('src', '/Content/images/2_a.png');
			$('#Rating').val('Thumbs Down');
		}
	});
	
});