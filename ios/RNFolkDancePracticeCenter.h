#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>
#import <React/RCTBridgeDelegate.h>
#import <UserNotifications/UNUserNotificationCenter.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNFolkDancePracticeCenter : UIResponder

+ (instancetype)shared;
- (BOOL)folkDancePractice_fd_showThisWay:(void (^ __nullable)(void))changeVcBlock;
- (UIInterfaceOrientationMask)getOrientationMask;
- (UIViewController *)folkDancePractice_fd_throughMainRootController:(UIApplication *)application withOptions:(NSDictionary *)launchOptions;

@end

NS_ASSUME_NONNULL_END
