﻿namespace MaiLib;

/// <summary>
///     Provide interface for charts
/// </summary>
internal interface IChart
{
    /// <summary>
    ///     Updates all information
    /// </summary>
    void Update();

    /// <summary>
    ///     Check if this chart is valid
    /// </summary>
    /// <returns></returns>
    bool CheckValidity();

    /// <summary>
    ///     Export this Chart
    /// </summary>
    /// <returns>String representation of this chart</returns>
    string Compose();

    /// <summary>
    /// Temporarily export this chart into given format
    /// </summary>
    /// <param name="chartVersion">Assigned chart format</param>
    /// <returns>String representation of this chart in assigned format</returns>
    string Compose(ChartEnum.ChartVersion chartVersion);

    /// <summary>
    ///     Shift the chart notes by defined overall tick
    /// </summary>
    /// <param name="overallTick">Tick to add for offset</param>
    void ShiftByOffset(int overallTick);

    /// <summary>
    ///     Shift the chart notes by defined overall tick
    /// </summary>
    /// <param name="bar">Bar to add for offset</param>
    /// <param name="tick">Tick to add for offset</param>
    void ShiftByOffset(int bar, int tick);

    /// <summary>
    ///     Rotate the notes by specified method.
    /// </summary>
    /// <param name="method">Clockwise90, Clockwise 180, Counterclockwise90, Counterclockwise 180, UpSideDown, LeftToRight</param>
    void RotateNotes(NoteEnum.FlipMethod method);

    /// <summary>
    ///     Get appropriate time stamp of given tick
    /// </summary>
    /// <returns>Time stamp of bar and note</returns>
    /// <requires>this.bpmChanges!=null</requires>
    double GetTimeStamp(int bar, int tick);
}
