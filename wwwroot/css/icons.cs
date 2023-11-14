namespace TheBlogProject.wwwroot.css
{
    public class icons
    {
        $blue-color : #3b5998;
$gray-color : #eee;

body {
  margin: 35px auto;
        text-align: center;
  display: block;
}

# facebook-icon {
    background: $blue-color;
  text-indent: -999em;
  width: 100px;
  height: 110px;
  border-radius: 5px;
  position: relative;
  overflow: hidden;
  border: 15px solid $blue-color;
  border-bottom: 0;
  display: inline-block;
  &::before {
    background: $blue-color;
    content: "/20";
    position: absolute;
    bottom: -30px;
    right: -37px;
    width: 40px;
    height: 90px;
    border: 20px solid $gray-color;
    border-radius: 25px;
  }
&::after {
background: $gray - color;
content: "/20";
position: absolute;
top: 50px;
right: 5px;
width: 55px;
height: 20px;
}
}
    }
}
