   M S B A M L   `   `   `  ����C  ?Praktika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Praktika.PagesPraktika.Pages  5          Praktika.Pages.First   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Praktika.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  First��5
      .��5      � 
�������.+�5   
   �� $	��350��6   $��	0,0,0,100q�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Choose��5         
FontFamily$ Verdana)�5      $��72��5       &  "MaterialDesignFloatingHintComboBox#��[  5      ��5      �� *Users+5      �� 5   
   $��Bottom=�6   $��0,0,300,150q�6,    " MaterialDesignRaisedDarkButton#��[ 5      $��90��5       � ToolTip$8 2Resource name: MaterialDesignRaisedLightDarkButton��5      $
��Edit��5      {�5      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window�� 5   
   $��Bottom=�6   $��0,0,100,150q�6,   #��[ 5       $��90��5!      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5"      $	��Add��5#      ��5$      �� *
AddCommand+��5%      ��  �� *FindAncestor+" N�{�5(      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window�� 5*   
   $��Bottom=�6   $��100,0,0,150q�6,   #��[ 5+      $��90��5,      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5-      $��Remove��5.      {�5/      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window�� 51   
   $��Bottom=�6   $��300,0,0,150q�6,   #��[ 52      $��90��53      $8 2Resource name: MaterialDesignRaisedLightDarkButton��54      $
��Show��55      ��56      �� *ShowCommand+��57      ��  �� *FindAncestor+" N�5:      5;      