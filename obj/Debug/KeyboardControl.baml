   M S B A M L   `   `   `  ????Q  MVirtualKeyboardControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:VirtualKeyboardControlVirtualKeyboardControl  5      ,    &VirtualKeyboardControl.KeyboardControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:VirtualKeyboardControl     5        ? 	Resources  5	       ?? MergedDictionaries ?? Source?? 5
   
    5      ?? 5      $Z Tpack://application:,,,/VirtualKeyboardControl;component/Resources/KeyboardStyle.xaml??6%   %    5      .??5      ? $	??500??6   $	??950??5      
??????? ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6   ?? 5      $??50 ?6   .+?5   
   ?? $??0q?6    ?? CornerRadius$ 5??6%   
???????$	??100??5      $??10q?5      ._?5      ?? -   5         ??Name$ 	TextValue??5       $??15 10 50 10q?5       ?? TextWrapping$
 Wrap=?5       
  Ubuntu#??[  5      $??20(?5!      ??5      ?? *	TextValue+ ?? Mode$ TwoWay=? ?? UpdateSourceTrigger$ PropertyChanged=?5!      5"      ?? 5#   
   $??1??6   ._?5$      ?? 	 ?? Orientation$	 Vertical=?6   $??Center=?60   $??10q?6K   .+?5%      ?? $	 
Horizontal=?6   $??Center=?66   .+?5&      ?? -   5        
 ??Name$
 	NumberRow??5&   #     KeysRow#??[ 5(      ??5'      ?? *NumberRowKeys+$ PropertyChanged=???5)      ?? 5*      .R?5+   "   ??   KeyStyle#??[ 6)   ??6K   ?? *
KeyValue+??5,      ?? *DataContext.InsertCharCommand+ ?? ElementName$ 	NumberRow????5-      ?? *
KeyValue+5.      50      ?? 51        SystemKeyStyle#??[ 6   $??<-??6p   $
??back??6?   ??6E   ?? *InserSpecialKeyCommand+6?   52      ?? 54      $	 
Horizontal=?6   $??Center=?66   .+?56      ?? -   5        $
 FirstRow??56   #   #??[ 58      ??57      ?? *FirstRowKeys+$ PropertyChanged=???59      ?? 5:      .R?5;   "   ?? #??[ 6)   ??6K   ?? *
KeyValue+??5<      ?? *DataContext.InsertCharCommand+$ FirstRow????5=      ?? *
KeyValue+5>      5@      5A      ?? 5C      $	 
Horizontal=?6   $??Center=?66   .+?5D      ?? -   5        $
 	SecondRow??5D   #   #??[ 5E      ??5F      ?? *SecondRowKeys+$ PropertyChanged=???5G      ?? 5H      .R?5I   "   ?? #??[ 6)   ??6K   ?? *
KeyValue+??5J      ?? *DataContext.InsertCharCommand+$ 	SecondRow????5K      ?? *
KeyValue+5L      5N      5O      ?? 5Q      $	 
Horizontal=?6   $??Center=?66   .+?5R      ?? $??CapsLk??6   #??[ 6.   ?? 5S      -   5        $
 ThirdRow??5S   #   #??[ 5T      ??5U      ?? *ThirdRowKeys+$ PropertyChanged=???5V      ?? 5W      .R?5X   "   ?? #??[ 6)   ??6K   ?? *
KeyValue+??5Y      ?? *DataContext.InsertCharCommand+$ ThirdRow????5Z      ?? *
KeyValue+5[      5]      ?? 5^      #??[ 6   $??enter??6p   $??Enter??6?   ??6E   ?? *InserSpecialKeyCommand+6?   5_      ?? 5`      $	 
Horizontal=?6   $??Center=?66   .+?5a      ??   SpaceKeyStyle#??[ 6   $??space??6o   $?? ??6?   ??6D   ?? *InserSpecialKeyCommand+6?   5b      5c      5d      ?? 5e   
   $??2??6   
???   ?._?5f      ?? $	 
Horizontal=?6   $??Right=?62   .+?5g      ?? $
??ОК??6     ControllerKey#??[ 6&   ?? 5h      $??ОТМЕНА??6   #??[ 6*   5i      5j      5k      5l      