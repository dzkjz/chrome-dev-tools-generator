namespace BaristaLabs.ChromeDevTools.Runtime
{
    using System;
    using System.Collections.Generic;

    public static class EventTypeMap
    {
        private readonly static IDictionary<string, Type> s_methodNameEventTypeDictionary;
        private readonly static IDictionary<Type, string> s_eventTypeMethodNameDictionary;

        static EventTypeMap()
        {
            s_methodNameEventTypeDictionary = new Dictionary<string, Type>()
            {
                { "Inspector.detached", typeof(Inspector.DetachedEvent) },
                { "Inspector.targetCrashed", typeof(Inspector.TargetCrashedEvent) },
                { "Page.domContentEventFired", typeof(Page.DomContentEventFiredEvent) },
                { "Page.loadEventFired", typeof(Page.LoadEventFiredEvent) },
                { "Page.frameAttached", typeof(Page.FrameAttachedEvent) },
                { "Page.frameNavigated", typeof(Page.FrameNavigatedEvent) },
                { "Page.frameDetached", typeof(Page.FrameDetachedEvent) },
                { "Page.frameStartedLoading", typeof(Page.FrameStartedLoadingEvent) },
                { "Page.frameStoppedLoading", typeof(Page.FrameStoppedLoadingEvent) },
                { "Page.frameScheduledNavigation", typeof(Page.FrameScheduledNavigationEvent) },
                { "Page.frameClearedScheduledNavigation", typeof(Page.FrameClearedScheduledNavigationEvent) },
                { "Page.frameResized", typeof(Page.FrameResizedEvent) },
                { "Page.javascriptDialogOpening", typeof(Page.JavascriptDialogOpeningEvent) },
                { "Page.javascriptDialogClosed", typeof(Page.JavascriptDialogClosedEvent) },
                { "Page.screencastFrame", typeof(Page.ScreencastFrameEvent) },
                { "Page.screencastVisibilityChanged", typeof(Page.ScreencastVisibilityChangedEvent) },
                { "Page.colorPicked", typeof(Page.ColorPickedEvent) },
                { "Page.interstitialShown", typeof(Page.InterstitialShownEvent) },
                { "Page.interstitialHidden", typeof(Page.InterstitialHiddenEvent) },
                { "Page.navigationRequested", typeof(Page.NavigationRequestedEvent) },
                { "Emulation.virtualTimeBudgetExpired", typeof(Emulation.VirtualTimeBudgetExpiredEvent) },
                { "Security.securityStateChanged", typeof(Security.SecurityStateChangedEvent) },
                { "Network.resourceChangedPriority", typeof(Network.ResourceChangedPriorityEvent) },
                { "Network.requestWillBeSent", typeof(Network.RequestWillBeSentEvent) },
                { "Network.requestServedFromCache", typeof(Network.RequestServedFromCacheEvent) },
                { "Network.responseReceived", typeof(Network.ResponseReceivedEvent) },
                { "Network.dataReceived", typeof(Network.DataReceivedEvent) },
                { "Network.loadingFinished", typeof(Network.LoadingFinishedEvent) },
                { "Network.loadingFailed", typeof(Network.LoadingFailedEvent) },
                { "Network.webSocketWillSendHandshakeRequest", typeof(Network.WebSocketWillSendHandshakeRequestEvent) },
                { "Network.webSocketHandshakeResponseReceived", typeof(Network.WebSocketHandshakeResponseReceivedEvent) },
                { "Network.webSocketCreated", typeof(Network.WebSocketCreatedEvent) },
                { "Network.webSocketClosed", typeof(Network.WebSocketClosedEvent) },
                { "Network.webSocketFrameReceived", typeof(Network.WebSocketFrameReceivedEvent) },
                { "Network.webSocketFrameError", typeof(Network.WebSocketFrameErrorEvent) },
                { "Network.webSocketFrameSent", typeof(Network.WebSocketFrameSentEvent) },
                { "Network.eventSourceMessageReceived", typeof(Network.EventSourceMessageReceivedEvent) },
                { "Database.addDatabase", typeof(Database.AddDatabaseEvent) },
                { "DOMStorage.domStorageItemsCleared", typeof(DOMStorage.DomStorageItemsClearedEvent) },
                { "DOMStorage.domStorageItemRemoved", typeof(DOMStorage.DomStorageItemRemovedEvent) },
                { "DOMStorage.domStorageItemAdded", typeof(DOMStorage.DomStorageItemAddedEvent) },
                { "DOMStorage.domStorageItemUpdated", typeof(DOMStorage.DomStorageItemUpdatedEvent) },
                { "ApplicationCache.applicationCacheStatusUpdated", typeof(ApplicationCache.ApplicationCacheStatusUpdatedEvent) },
                { "ApplicationCache.networkStateUpdated", typeof(ApplicationCache.NetworkStateUpdatedEvent) },
                { "DOM.documentUpdated", typeof(DOM.DocumentUpdatedEvent) },
                { "DOM.inspectNodeRequested", typeof(DOM.InspectNodeRequestedEvent) },
                { "DOM.setChildNodes", typeof(DOM.SetChildNodesEvent) },
                { "DOM.attributeModified", typeof(DOM.AttributeModifiedEvent) },
                { "DOM.attributeRemoved", typeof(DOM.AttributeRemovedEvent) },
                { "DOM.inlineStyleInvalidated", typeof(DOM.InlineStyleInvalidatedEvent) },
                { "DOM.characterDataModified", typeof(DOM.CharacterDataModifiedEvent) },
                { "DOM.childNodeCountUpdated", typeof(DOM.ChildNodeCountUpdatedEvent) },
                { "DOM.childNodeInserted", typeof(DOM.ChildNodeInsertedEvent) },
                { "DOM.childNodeRemoved", typeof(DOM.ChildNodeRemovedEvent) },
                { "DOM.shadowRootPushed", typeof(DOM.ShadowRootPushedEvent) },
                { "DOM.shadowRootPopped", typeof(DOM.ShadowRootPoppedEvent) },
                { "DOM.pseudoElementAdded", typeof(DOM.PseudoElementAddedEvent) },
                { "DOM.pseudoElementRemoved", typeof(DOM.PseudoElementRemovedEvent) },
                { "DOM.distributedNodesUpdated", typeof(DOM.DistributedNodesUpdatedEvent) },
                { "DOM.nodeHighlightRequested", typeof(DOM.NodeHighlightRequestedEvent) },
                { "CSS.mediaQueryResultChanged", typeof(CSS.MediaQueryResultChangedEvent) },
                { "CSS.fontsUpdated", typeof(CSS.FontsUpdatedEvent) },
                { "CSS.styleSheetChanged", typeof(CSS.StyleSheetChangedEvent) },
                { "CSS.styleSheetAdded", typeof(CSS.StyleSheetAddedEvent) },
                { "CSS.styleSheetRemoved", typeof(CSS.StyleSheetRemovedEvent) },
                { "Target.targetCreated", typeof(Target.TargetCreatedEvent) },
                { "Target.targetDestroyed", typeof(Target.TargetDestroyedEvent) },
                { "Target.attachedToTarget", typeof(Target.AttachedToTargetEvent) },
                { "Target.detachedFromTarget", typeof(Target.DetachedFromTargetEvent) },
                { "Target.receivedMessageFromTarget", typeof(Target.ReceivedMessageFromTargetEvent) },
                { "ServiceWorker.workerRegistrationUpdated", typeof(ServiceWorker.WorkerRegistrationUpdatedEvent) },
                { "ServiceWorker.workerVersionUpdated", typeof(ServiceWorker.WorkerVersionUpdatedEvent) },
                { "ServiceWorker.workerErrorReported", typeof(ServiceWorker.WorkerErrorReportedEvent) },
                { "LayerTree.layerTreeDidChange", typeof(LayerTree.LayerTreeDidChangeEvent) },
                { "LayerTree.layerPainted", typeof(LayerTree.LayerPaintedEvent) },
                { "Tracing.dataCollected", typeof(Tracing.DataCollectedEvent) },
                { "Tracing.tracingComplete", typeof(Tracing.TracingCompleteEvent) },
                { "Tracing.bufferUsage", typeof(Tracing.BufferUsageEvent) },
                { "Animation.animationCreated", typeof(Animation.AnimationCreatedEvent) },
                { "Animation.animationStarted", typeof(Animation.AnimationStartedEvent) },
                { "Animation.animationCanceled", typeof(Animation.AnimationCanceledEvent) },
                { "Log.entryAdded", typeof(Log.EntryAddedEvent) },
                { "Tethering.accepted", typeof(Tethering.AcceptedEvent) },
                { "Runtime.executionContextCreated", typeof(Runtime.ExecutionContextCreatedEvent) },
                { "Runtime.executionContextDestroyed", typeof(Runtime.ExecutionContextDestroyedEvent) },
                { "Runtime.executionContextsCleared", typeof(Runtime.ExecutionContextsClearedEvent) },
                { "Runtime.exceptionThrown", typeof(Runtime.ExceptionThrownEvent) },
                { "Runtime.exceptionRevoked", typeof(Runtime.ExceptionRevokedEvent) },
                { "Runtime.consoleAPICalled", typeof(Runtime.ConsoleAPICalledEvent) },
                { "Runtime.inspectRequested", typeof(Runtime.InspectRequestedEvent) },
                { "Debugger.scriptParsed", typeof(Debugger.ScriptParsedEvent) },
                { "Debugger.scriptFailedToParse", typeof(Debugger.ScriptFailedToParseEvent) },
                { "Debugger.breakpointResolved", typeof(Debugger.BreakpointResolvedEvent) },
                { "Debugger.paused", typeof(Debugger.PausedEvent) },
                { "Debugger.resumed", typeof(Debugger.ResumedEvent) },
                { "Console.messageAdded", typeof(Console.MessageAddedEvent) },
                { "Profiler.consoleProfileStarted", typeof(Profiler.ConsoleProfileStartedEvent) },
                { "Profiler.consoleProfileFinished", typeof(Profiler.ConsoleProfileFinishedEvent) },
                { "HeapProfiler.addHeapSnapshotChunk", typeof(HeapProfiler.AddHeapSnapshotChunkEvent) },
                { "HeapProfiler.resetProfiles", typeof(HeapProfiler.ResetProfilesEvent) },
                { "HeapProfiler.reportHeapSnapshotProgress", typeof(HeapProfiler.ReportHeapSnapshotProgressEvent) },
                { "HeapProfiler.lastSeenObjectId", typeof(HeapProfiler.LastSeenObjectIdEvent) },
                { "HeapProfiler.heapStatsUpdate", typeof(HeapProfiler.HeapStatsUpdateEvent) },
            };

            s_eventTypeMethodNameDictionary = new Dictionary<Type, string>()
            {
                { typeof(Inspector.DetachedEvent), "Inspector.detached" },
                { typeof(Inspector.TargetCrashedEvent), "Inspector.targetCrashed" },
                { typeof(Page.DomContentEventFiredEvent), "Page.domContentEventFired" },
                { typeof(Page.LoadEventFiredEvent), "Page.loadEventFired" },
                { typeof(Page.FrameAttachedEvent), "Page.frameAttached" },
                { typeof(Page.FrameNavigatedEvent), "Page.frameNavigated" },
                { typeof(Page.FrameDetachedEvent), "Page.frameDetached" },
                { typeof(Page.FrameStartedLoadingEvent), "Page.frameStartedLoading" },
                { typeof(Page.FrameStoppedLoadingEvent), "Page.frameStoppedLoading" },
                { typeof(Page.FrameScheduledNavigationEvent), "Page.frameScheduledNavigation" },
                { typeof(Page.FrameClearedScheduledNavigationEvent), "Page.frameClearedScheduledNavigation" },
                { typeof(Page.FrameResizedEvent), "Page.frameResized" },
                { typeof(Page.JavascriptDialogOpeningEvent), "Page.javascriptDialogOpening" },
                { typeof(Page.JavascriptDialogClosedEvent), "Page.javascriptDialogClosed" },
                { typeof(Page.ScreencastFrameEvent), "Page.screencastFrame" },
                { typeof(Page.ScreencastVisibilityChangedEvent), "Page.screencastVisibilityChanged" },
                { typeof(Page.ColorPickedEvent), "Page.colorPicked" },
                { typeof(Page.InterstitialShownEvent), "Page.interstitialShown" },
                { typeof(Page.InterstitialHiddenEvent), "Page.interstitialHidden" },
                { typeof(Page.NavigationRequestedEvent), "Page.navigationRequested" },
                { typeof(Emulation.VirtualTimeBudgetExpiredEvent), "Emulation.virtualTimeBudgetExpired" },
                { typeof(Security.SecurityStateChangedEvent), "Security.securityStateChanged" },
                { typeof(Network.ResourceChangedPriorityEvent), "Network.resourceChangedPriority" },
                { typeof(Network.RequestWillBeSentEvent), "Network.requestWillBeSent" },
                { typeof(Network.RequestServedFromCacheEvent), "Network.requestServedFromCache" },
                { typeof(Network.ResponseReceivedEvent), "Network.responseReceived" },
                { typeof(Network.DataReceivedEvent), "Network.dataReceived" },
                { typeof(Network.LoadingFinishedEvent), "Network.loadingFinished" },
                { typeof(Network.LoadingFailedEvent), "Network.loadingFailed" },
                { typeof(Network.WebSocketWillSendHandshakeRequestEvent), "Network.webSocketWillSendHandshakeRequest" },
                { typeof(Network.WebSocketHandshakeResponseReceivedEvent), "Network.webSocketHandshakeResponseReceived" },
                { typeof(Network.WebSocketCreatedEvent), "Network.webSocketCreated" },
                { typeof(Network.WebSocketClosedEvent), "Network.webSocketClosed" },
                { typeof(Network.WebSocketFrameReceivedEvent), "Network.webSocketFrameReceived" },
                { typeof(Network.WebSocketFrameErrorEvent), "Network.webSocketFrameError" },
                { typeof(Network.WebSocketFrameSentEvent), "Network.webSocketFrameSent" },
                { typeof(Network.EventSourceMessageReceivedEvent), "Network.eventSourceMessageReceived" },
                { typeof(Database.AddDatabaseEvent), "Database.addDatabase" },
                { typeof(DOMStorage.DomStorageItemsClearedEvent), "DOMStorage.domStorageItemsCleared" },
                { typeof(DOMStorage.DomStorageItemRemovedEvent), "DOMStorage.domStorageItemRemoved" },
                { typeof(DOMStorage.DomStorageItemAddedEvent), "DOMStorage.domStorageItemAdded" },
                { typeof(DOMStorage.DomStorageItemUpdatedEvent), "DOMStorage.domStorageItemUpdated" },
                { typeof(ApplicationCache.ApplicationCacheStatusUpdatedEvent), "ApplicationCache.applicationCacheStatusUpdated" },
                { typeof(ApplicationCache.NetworkStateUpdatedEvent), "ApplicationCache.networkStateUpdated" },
                { typeof(DOM.DocumentUpdatedEvent), "DOM.documentUpdated" },
                { typeof(DOM.InspectNodeRequestedEvent), "DOM.inspectNodeRequested" },
                { typeof(DOM.SetChildNodesEvent), "DOM.setChildNodes" },
                { typeof(DOM.AttributeModifiedEvent), "DOM.attributeModified" },
                { typeof(DOM.AttributeRemovedEvent), "DOM.attributeRemoved" },
                { typeof(DOM.InlineStyleInvalidatedEvent), "DOM.inlineStyleInvalidated" },
                { typeof(DOM.CharacterDataModifiedEvent), "DOM.characterDataModified" },
                { typeof(DOM.ChildNodeCountUpdatedEvent), "DOM.childNodeCountUpdated" },
                { typeof(DOM.ChildNodeInsertedEvent), "DOM.childNodeInserted" },
                { typeof(DOM.ChildNodeRemovedEvent), "DOM.childNodeRemoved" },
                { typeof(DOM.ShadowRootPushedEvent), "DOM.shadowRootPushed" },
                { typeof(DOM.ShadowRootPoppedEvent), "DOM.shadowRootPopped" },
                { typeof(DOM.PseudoElementAddedEvent), "DOM.pseudoElementAdded" },
                { typeof(DOM.PseudoElementRemovedEvent), "DOM.pseudoElementRemoved" },
                { typeof(DOM.DistributedNodesUpdatedEvent), "DOM.distributedNodesUpdated" },
                { typeof(DOM.NodeHighlightRequestedEvent), "DOM.nodeHighlightRequested" },
                { typeof(CSS.MediaQueryResultChangedEvent), "CSS.mediaQueryResultChanged" },
                { typeof(CSS.FontsUpdatedEvent), "CSS.fontsUpdated" },
                { typeof(CSS.StyleSheetChangedEvent), "CSS.styleSheetChanged" },
                { typeof(CSS.StyleSheetAddedEvent), "CSS.styleSheetAdded" },
                { typeof(CSS.StyleSheetRemovedEvent), "CSS.styleSheetRemoved" },
                { typeof(Target.TargetCreatedEvent), "Target.targetCreated" },
                { typeof(Target.TargetDestroyedEvent), "Target.targetDestroyed" },
                { typeof(Target.AttachedToTargetEvent), "Target.attachedToTarget" },
                { typeof(Target.DetachedFromTargetEvent), "Target.detachedFromTarget" },
                { typeof(Target.ReceivedMessageFromTargetEvent), "Target.receivedMessageFromTarget" },
                { typeof(ServiceWorker.WorkerRegistrationUpdatedEvent), "ServiceWorker.workerRegistrationUpdated" },
                { typeof(ServiceWorker.WorkerVersionUpdatedEvent), "ServiceWorker.workerVersionUpdated" },
                { typeof(ServiceWorker.WorkerErrorReportedEvent), "ServiceWorker.workerErrorReported" },
                { typeof(LayerTree.LayerTreeDidChangeEvent), "LayerTree.layerTreeDidChange" },
                { typeof(LayerTree.LayerPaintedEvent), "LayerTree.layerPainted" },
                { typeof(Tracing.DataCollectedEvent), "Tracing.dataCollected" },
                { typeof(Tracing.TracingCompleteEvent), "Tracing.tracingComplete" },
                { typeof(Tracing.BufferUsageEvent), "Tracing.bufferUsage" },
                { typeof(Animation.AnimationCreatedEvent), "Animation.animationCreated" },
                { typeof(Animation.AnimationStartedEvent), "Animation.animationStarted" },
                { typeof(Animation.AnimationCanceledEvent), "Animation.animationCanceled" },
                { typeof(Log.EntryAddedEvent), "Log.entryAdded" },
                { typeof(Tethering.AcceptedEvent), "Tethering.accepted" },
                { typeof(Runtime.ExecutionContextCreatedEvent), "Runtime.executionContextCreated" },
                { typeof(Runtime.ExecutionContextDestroyedEvent), "Runtime.executionContextDestroyed" },
                { typeof(Runtime.ExecutionContextsClearedEvent), "Runtime.executionContextsCleared" },
                { typeof(Runtime.ExceptionThrownEvent), "Runtime.exceptionThrown" },
                { typeof(Runtime.ExceptionRevokedEvent), "Runtime.exceptionRevoked" },
                { typeof(Runtime.ConsoleAPICalledEvent), "Runtime.consoleAPICalled" },
                { typeof(Runtime.InspectRequestedEvent), "Runtime.inspectRequested" },
                { typeof(Debugger.ScriptParsedEvent), "Debugger.scriptParsed" },
                { typeof(Debugger.ScriptFailedToParseEvent), "Debugger.scriptFailedToParse" },
                { typeof(Debugger.BreakpointResolvedEvent), "Debugger.breakpointResolved" },
                { typeof(Debugger.PausedEvent), "Debugger.paused" },
                { typeof(Debugger.ResumedEvent), "Debugger.resumed" },
                { typeof(Console.MessageAddedEvent), "Console.messageAdded" },
                { typeof(Profiler.ConsoleProfileStartedEvent), "Profiler.consoleProfileStarted" },
                { typeof(Profiler.ConsoleProfileFinishedEvent), "Profiler.consoleProfileFinished" },
                { typeof(HeapProfiler.AddHeapSnapshotChunkEvent), "HeapProfiler.addHeapSnapshotChunk" },
                { typeof(HeapProfiler.ResetProfilesEvent), "HeapProfiler.resetProfiles" },
                { typeof(HeapProfiler.ReportHeapSnapshotProgressEvent), "HeapProfiler.reportHeapSnapshotProgress" },
                { typeof(HeapProfiler.LastSeenObjectIdEvent), "HeapProfiler.lastSeenObjectId" },
                { typeof(HeapProfiler.HeapStatsUpdateEvent), "HeapProfiler.heapStatsUpdate" },
            };
        }

        /// <summary>
        /// Gets the event type corresponding to the specified method name.
        /// </summary>
        public static bool TryGetTypeForMethodName(string methodName, out Type eventType)
        {
            return s_methodNameEventTypeDictionary.TryGetValue(methodName, out eventType);
        }

        /// <summary>
        /// Gets the method name corresponding to the specified event type.
        /// </summary>
        public static bool TryGetMethodNameForType<TEvent>(out string methodName)
            where TEvent : IEvent
        {
            return s_eventTypeMethodNameDictionary.TryGetValue(typeof(TEvent), out methodName);
        }
    }
}